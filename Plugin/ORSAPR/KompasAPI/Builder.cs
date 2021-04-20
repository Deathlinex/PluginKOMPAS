using System;
using Kompas6API5;
using Kompas6Constants3D;
using KompasAPI.Model;

namespace KompasAPI
{
    /// <summary>
    /// Класс построения модели
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// Построение модели
        /// </summary>
        /// <param name="kompasConnector">API Компаса</param>
        /// <param name="modelParameters">Параметры модели</param>
        public void Build(KompasConnector kompasConnector, ModelParameters modelParameters)
        {
            CreateCase(kompasConnector, modelParameters);
            CreateButtons(kompasConnector, modelParameters);
            CreateRectangleButton(kompasConnector, modelParameters);
            CreateRectangleDoor(kompasConnector, modelParameters);
        }

        /// <summary>
        /// Построение корпуса модели
        /// </summary>
        /// <param name="kompasConnector">API Компас-3D</param>
        /// <param name="modelParameters">Параметры модели</param>
        private void CreateCase(KompasConnector kompasConnector, ModelParameters modelParameters)
        {
            // Текущая плоскость - XOZ
            ksEntity currentPlane = (ksEntity)kompasConnector.KsPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ);

            // Эскиз
            ksEntity frameSketch = (ksEntity)kompasConnector.KsPart.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition frameSketchDef = frameSketch.GetDefinition();
            frameSketchDef.SetPlane(currentPlane);
            frameSketch.Create();
            kompasConnector.KsDocument2D = (ksDocument2D)frameSketchDef.BeginEdit();

            // Построение прямоугольника
            CreateRectangle(kompasConnector, modelParameters.CaseHeight.Value, 0, -modelParameters.CaseLength.Value, 0);

            frameSketchDef.EndEdit();

            // Выдавливание
            Extrusion(kompasConnector, frameSketch, modelParameters.CaseDepth.Value);

            // Скругление
            Fillet(kompasConnector, ModelParameters.caseCenterX, modelParameters.CaseDepth.Value, ModelParameters.caseCoordZ, ModelParameters.caseFilletRadius);
            Fillet(kompasConnector, -modelParameters.CaseLength.Value, modelParameters.CaseDepth.Value, ModelParameters.caseCoordZ, ModelParameters.caseFilletRadius);
            Fillet(kompasConnector, -modelParameters.CaseLength.Value / 2, modelParameters.CaseDepth.Value, ModelParameters.caseCenterZ, ModelParameters.caseFilletRadius);
        }

        /// <summary>
        /// Построение круглых кнопок
        /// </summary>
        /// <param name="kompasConnector">API Компас-3D</param>
        /// <param name="modelParameters">Параметры модели</param>
        private void CreateButtons(KompasConnector kompasConnector, ModelParameters modelParameters)
        {
            // Текущая плоскость - XOZ
            ksEntity currentPlane = (ksEntity)kompasConnector.KsPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ);
            currentPlane = OffsetPlane(kompasConnector, currentPlane, true, modelParameters.CaseDepth.Value);

            // Эскиз
            ksEntity frameSketch = (ksEntity)kompasConnector.KsPart.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition frameSketchDef = frameSketch.GetDefinition();
            frameSketchDef.SetPlane(currentPlane);
            frameSketch.Create();
            kompasConnector.KsDocument2D = (ksDocument2D)frameSketchDef.BeginEdit();

            var radius = modelParameters.DiameterOfButtons.Value / 2;
            var partLength = modelParameters.CaseLength.Value / 10;
            var partHeight = modelParameters.CaseHeight.Value / 10;

            //Построение кругов
            kompasConnector.KsDocument2D.ksCircle(-partLength * 9, partHeight * 1.5, ModelParameters.defaultButtonRadius, 1);
            kompasConnector.KsDocument2D.ksCircle(-partLength * 8, partHeight * 1.5, radius, 1);
            kompasConnector.KsDocument2D.ksCircle(-partLength * 9, partHeight * 3, radius, 1);
            frameSketchDef.EndEdit();

            // Выдавливание
            Extrusion(kompasConnector, frameSketch, ModelParameters.circleButtonExtrusionDepth);

            // Скругление
            Fillet(kompasConnector,
                ModelParameters.cirleFirstButtonFilletX * modelParameters.CaseLength.Value,
                modelParameters.CaseDepth.Value + ModelParameters.circleButtonFilletY,
                -(ModelParameters.circleFirstButtonFilletZ * modelParameters.CaseHeight.Value + radius),
                ModelParameters.circleButtonRadius);
            Fillet(kompasConnector,
                ModelParameters.circleSecondButtonFilletX * modelParameters.CaseLength.Value,
                modelParameters.CaseDepth.Value + ModelParameters.circleButtonFilletY,
                -(ModelParameters.circleSecondButtonFilletZ * modelParameters.CaseHeight.Value + radius),
                ModelParameters.circleButtonRadius);
        }

        /// <summary>
        /// Построение прямоугольной кнопки
        /// </summary>
        /// <param name="kompasConnector">API Компас-3D</param>
        /// <param name="modelParameters">Параметры модели</param>
        private void CreateRectangleButton(KompasConnector kompasConnector, ModelParameters modelParameters)
        {
            // Текущая плоскость - XOZ
            ksEntity currentPlane = (ksEntity)kompasConnector.KsPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ);
            currentPlane = OffsetPlane(kompasConnector, currentPlane, true, modelParameters.CaseDepth.Value);

            // Эскиз 
            ksEntity frameSketch = (ksEntity)kompasConnector.KsPart.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition frameSketchDef = frameSketch.GetDefinition();
            frameSketchDef.SetPlane(currentPlane);
            frameSketch.Create();
            kompasConnector.KsDocument2D = (ksDocument2D)frameSketchDef.BeginEdit();

            //Построение прямоугольника
            CreateRectangle(kompasConnector,
                modelParameters.CaseHeight.Value - ModelParameters.rectangleButtonIndentY,
                modelParameters.CaseHeight.Value - ModelParameters.rectangleButtonIndentY - modelParameters.ButtonHeight.Value,
                -(modelParameters.CaseLength.Value - ModelParameters.rectangleButtonIndentX),
                -(modelParameters.CaseLength.Value - ModelParameters.rectangleButtonIndentX) + modelParameters.ButtonLength.Value);

            frameSketchDef.EndEdit();

            // Выдавливание
            Extrusion(kompasConnector, frameSketch, ModelParameters.rectangleButtonExtrusionDepth);
        }

        /// <summary>
        /// Построение дверцы
        /// </summary>
        /// <param name="kompasConnector">API Компас-3D</param>
        /// <param name="modelParameters">Параметры модели</param>
        private void CreateRectangleDoor(KompasConnector kompasConnector, ModelParameters modelParameters)
        {
            // Текущая плоскость - XOZ
            ksEntity currentPlane = (ksEntity)kompasConnector.KsPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ);
            currentPlane = OffsetPlane(kompasConnector, currentPlane, true, modelParameters.CaseDepth.Value);

            // Эскиз
            ksEntity frameSketch = (ksEntity)kompasConnector.KsPart.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition frameSketchDef = frameSketch.GetDefinition();
            frameSketchDef.SetPlane(currentPlane);
            frameSketch.Create();
            kompasConnector.KsDocument2D = (ksDocument2D)frameSketchDef.BeginEdit();

            var y_min = ((modelParameters.CaseHeight.Value / 2) - (modelParameters.DoorHeight.Value / 2)) + ModelParameters.rectangleDoorY;
            var y_max = (modelParameters.CaseHeight.Value / 2) + (modelParameters.DoorHeight.Value / 2);
            var x_min = ModelParameters.rectangleDoorCenterX + ModelParameters.rectangleDoorX;
            var x_max = x_min + modelParameters.DoorLength.Value;

            // Построение прямоугольника
            CreateRectangle(kompasConnector, y_min, y_max, -x_min, -x_max);

            frameSketchDef.EndEdit();

            // Выдавливание
            Extrusion(kompasConnector, frameSketch, ModelParameters.rectangleDoorExtrusionDepth);
        }

        /// <summary>
        /// Смещённая плоскость
        /// </summary>
        /// <param name="kompasConnector">API Компаса</param>
        /// <param name="plane">Плоскость</param>
        /// <param name="direction">Направление</param>
        /// <param name="offset">Расстояние</param>
        private ksEntity OffsetPlane(KompasConnector kompasConnector, ksEntity plane, bool direction, double offset)
        {
            ksEntity newPlane = (ksEntity)kompasConnector.KsPart.NewEntity((short)Obj3dType.o3d_planeOffset);
            ksPlaneOffsetDefinition newPlaneDef = (ksPlaneOffsetDefinition)newPlane.GetDefinition();
            newPlaneDef.SetPlane(plane);
            newPlaneDef.direction = direction;
            newPlaneDef.offset = offset;
            newPlane.Create();
            return newPlane;
        }

        /// <summary>
        /// Скругление
        /// </summary>
        /// <param name="kompasConnector">API Компаса</param>
        /// <param name="x">Координата X </param>
        /// <param name="y">Координата Y </param>
        /// <param name="z">Координата Z </param>
        /// <param name="radius">Радиус </param>
        private void Fillet(KompasConnector kompasConnector, double x, double y, double z, double radius)
        {
            ksEntity fillet = (ksEntity)kompasConnector.KsPart.NewEntity((short)Obj3dType.o3d_fillet);
            ksFilletDefinition filletDef = (ksFilletDefinition)fillet.GetDefinition();
            filletDef.radius = radius;
            filletDef.tangent = false;
            ksEntityCollection entityCollectionPart = (ksEntityCollection)kompasConnector.KsPart.EntityCollection((short)Obj3dType.o3d_edge);
            ksEntityCollection entityCollectionFillet = (ksEntityCollection)filletDef.array();
            entityCollectionFillet.Clear();
            entityCollectionPart.SelectByPoint(x, y, z);
            entityCollectionFillet.Add(entityCollectionPart.First());
            fillet.Create();
        }

        /// <summary>
        /// Выдавливание
        /// </summary>
        /// <param name="kompasConnector">API Компаса</param>
        /// <param name="sketch">Эскиз</param>
        /// <param name="depth">Глубина</param>
        private void Extrusion(KompasConnector kompasConnector, ksEntity sketch, double depth)
        {
            ksEntity extrusion = (ksEntity)kompasConnector.KsPart.NewEntity((short)Obj3dType.o3d_bossExtrusion);
            ksBossExtrusionDefinition extrusionDef = (ksBossExtrusionDefinition)extrusion.GetDefinition();
            ksExtrusionParam extrusionParam = (ksExtrusionParam)extrusionDef.ExtrusionParam();
            extrusionParam.typeNormal = (short)End_Type.etBlind;
            extrusionDef.SetSketch(sketch);
            extrusionParam.direction = (short)Direction_Type.dtNormal;
            extrusionParam.depthNormal = depth;
            extrusion.Create();
        }

        /// <summary>
        /// Создание прямоугольника по координатам
        /// </summary>
        /// <param name="kompasConnector">API Компаса</param>
        /// <param name="maxHeight">Максимальная высота</param>
        /// <param name="minHeight">Минимальная высота</param>
        /// <param name="maxWidth">Максимальная ширина</param>
        /// <param name="minWidth">Минимальная ширина</param>
        private void CreateRectangle(KompasConnector kompasConnector, double maxHeight, double minHeight, double maxWidth, double minWidth)
        {
            kompasConnector.KsDocument2D.ksLineSeg(minWidth, minHeight, minWidth, maxHeight, 1);
            kompasConnector.KsDocument2D.ksLineSeg(minWidth, maxHeight, maxWidth, maxHeight, 1);
            kompasConnector.KsDocument2D.ksLineSeg(maxWidth, maxHeight, maxWidth, minHeight, 1);
            kompasConnector.KsDocument2D.ksLineSeg(maxWidth, minHeight, minWidth, minHeight, 1);
        }
    }
}