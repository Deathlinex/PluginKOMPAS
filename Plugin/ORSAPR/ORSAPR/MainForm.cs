using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KompasAPI;
using KompasAPI.Model;

namespace ORSAPR
{
    /// <summary>
    /// Класс основной формы
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Параметры модели
        /// </summary>
        private ModelParameters _modelParameters;

        /// <summary>
        /// Билдер модели
        /// </summary>
        private Builder _builder;

        /// <summary>
        /// Компас коннектор
        /// </summary>
        private KompasConnector _kompasConnector;

        /// <summary>
        /// Словарь корректных значений
        /// </summary>
        private Dictionary<TextBox, bool> _correctValue;

        /// <summary>
        /// Основная форма
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _correctValue = new Dictionary<TextBox, bool>()
            {
                {CaseLengthTextBox, false},
                {CaseDepthTextBox, false},
                {DoorLengthTextBox, false},
                {DiameterOfButtonsTextBox, false},
                {CaseHeightTextBox, false},
                {ButtonLengthTextBox, false},
                {ButtonHeightTextBox, false},
                {DoorHeightTextBox, false}
            };

            _builder = new Builder();
            _modelParameters = new ModelParameters();
            FillTextBoxes();
        }

        /// <summary>
        /// Событие нажатия кнопки "Построить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            try
            {
                _kompasConnector = new KompasConnector();
                _kompasConnector.OpenKompas();
                _kompasConnector.CreateNewDocument();
                _builder.Build(_kompasConnector, _modelParameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Изменение значения "Длина дверцы"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoorLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxValueCheck(DoorLengthTextBox, _modelParameters.DoorLength);
        }

        /// <summary>
        /// Изменение значения "Длина кейса"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _modelParameters = new ModelParameters(Int32.Parse(CaseDepthTextBox.Text),
                    Int32.Parse(DiameterOfButtonsTextBox.Text),
                    Int32.Parse(CaseLengthTextBox.Text),
                    Int32.Parse(CaseHeightTextBox.Text),
                    Int32.Parse(ButtonLengthTextBox.Text),
                    Int32.Parse(ButtonHeightTextBox.Text));
                FillTextBoxes();
            }
            //TODO:
            catch (Exception)
            {}
            TextBoxValueCheck(CaseLengthTextBox, _modelParameters.CaseLength);
        }

        /// <summary>
        /// Изменение значения "Высота дверцы"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoorHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxValueCheck(DoorHeightTextBox, _modelParameters.DoorHeight);
        }

        /// <summary>
        /// Изменение значения "Высота кейса"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _modelParameters = new ModelParameters(Int32.Parse(CaseDepthTextBox.Text),
                    Int32.Parse(DiameterOfButtonsTextBox.Text),
                    Int32.Parse(CaseLengthTextBox.Text),
                    Int32.Parse(CaseHeightTextBox.Text),
                    Int32.Parse(ButtonLengthTextBox.Text),
                    Int32.Parse(ButtonHeightTextBox.Text));
                FillTextBoxes();
            }
            //TODO:
            catch (Exception)
            {}
            TextBoxValueCheck(CaseHeightTextBox, _modelParameters.CaseHeight);
        }

        /// <summary>
        /// Изменение значения "Глубина кейса"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaseDepthTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxValueCheck(CaseDepthTextBox, _modelParameters.CaseDepth);
        }
      
        /// <summary>
        /// Изменение значения "Диаметр кнопок"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiameterOfButtonsTextBox_TextChanged(object sender, EventArgs e)
        {
            //TODO: Duplication
            TextBoxValueCheck(DiameterOfButtonsTextBox, _modelParameters.DiameterOfButtons);
        }
        
        /// <summary>
        /// Изменение значения "Длина кнопки"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            //TODO: Duplication
            TextBoxValueCheck(ButtonLengthTextBox, _modelParameters.ButtonLength);
        }

        /// <summary>
        /// Изменение значения "Высота кнопки"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            //TODO: Duplication
            TextBoxValueCheck(ButtonHeightTextBox, _modelParameters.ButtonHeight);
        }
        
        /// <summary>
        /// Заполнение значений
        /// </summary>
        private void FillTextBoxes()
        {
            CaseLengthTextBox.Text = _modelParameters.CaseLength.Value.ToString();
            CaseDepthTextBox.Text = _modelParameters.CaseDepth.Value.ToString();
            DoorLengthTextBox.Text = _modelParameters.DoorLength.Value.ToString();
            DiameterOfButtonsTextBox.Text = _modelParameters.DiameterOfButtons.Value.ToString();
            CaseHeightTextBox.Text = _modelParameters.CaseHeight.Value.ToString();
            ButtonLengthTextBox.Text = _modelParameters.ButtonLength.Value.ToString();
            ButtonHeightTextBox.Text = _modelParameters.ButtonHeight.Value.ToString();
            DoorHeightTextBox.Text = _modelParameters.DoorHeight.Value.ToString();
        }

        /// <summary>
        /// Проверка корректных значений
        /// </summary>
        /// <param name="textBox">Текстовое поле</param>
        /// <param name="parameter">Параметр</param>
        private void TextBoxValueCheck(TextBox textBox, Parameter parameter)
        {
            try
            {
                parameter.Value = Int32.Parse(textBox.Text);
                ErrorToolTip.Active = false;
                textBox.ForeColor = Color.Black;
                _correctValue[textBox] = true;
            }
            catch (Exception ex)
            {
                ErrorToolTip.Active = true;
                ErrorToolTip.Show(ex.Message, textBox);
                textBox.ForeColor = Color.Red;
                _correctValue[textBox] = false;
            }
            finally
            {
                BuildButton.Enabled = _correctValue.All(i => i.Value);
            }
        }

    }
}