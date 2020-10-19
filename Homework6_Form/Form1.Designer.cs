namespace Homework6_Form
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDiscription = new System.Windows.Forms.Label();
            this.btnFileChouse = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblCountDescription = new System.Windows.Forms.Label();
            this.btnResize = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblResizeResult = new System.Windows.Forms.Label();
            this.lblResizeResultText = new System.Windows.Forms.Label();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.opnFIle = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.lblSaveText = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTimeText = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnOpenResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.Location = new System.Drawing.Point(9, 9);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(303, 39);
            this.lblDiscription.TabIndex = 0;
            this.lblDiscription.Text = "Выберите файл, который содержит число до 1000000000. \r\nПрограмма разделит число н" +
    "а составляющие\r\n и распределит по группам неделимых чисел.";
            // 
            // btnFileChouse
            // 
            this.btnFileChouse.Location = new System.Drawing.Point(12, 54);
            this.btnFileChouse.Name = "btnFileChouse";
            this.btnFileChouse.Size = new System.Drawing.Size(82, 39);
            this.btnFileChouse.TabIndex = 1;
            this.btnFileChouse.Text = "Открыть";
            this.btnFileChouse.UseVisualStyleBackColor = true;
            this.btnFileChouse.Click += new System.EventHandler(this.BtnFileChouse_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(100, 67);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(74, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Путь к файлу";
            // 
            // lblCountDescription
            // 
            this.lblCountDescription.AutoSize = true;
            this.lblCountDescription.Location = new System.Drawing.Point(362, 54);
            this.lblCountDescription.Name = "lblCountDescription";
            this.lblCountDescription.Size = new System.Drawing.Size(192, 13);
            this.lblCountDescription.TabIndex = 3;
            this.lblCountDescription.Text = "Количество групп в итоговом файле";
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(12, 235);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(82, 39);
            this.btnResize.TabIndex = 5;
            this.btnResize.Text = "Архивация";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.BtnResize_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(362, 80);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(98, 13);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Количество строк";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(362, 103);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(81, 13);
            this.lblFileSize.TabIndex = 7;
            this.lblFileSize.Text = "Размер файла";
            // 
            // lblResizeResult
            // 
            this.lblResizeResult.AutoSize = true;
            this.lblResizeResult.Location = new System.Drawing.Point(362, 261);
            this.lblResizeResult.Name = "lblResizeResult";
            this.lblResizeResult.Size = new System.Drawing.Size(134, 13);
            this.lblResizeResult.TabIndex = 8;
            this.lblResizeResult.Text = "размер после архивации";
            // 
            // lblResizeResultText
            // 
            this.lblResizeResultText.AutoSize = true;
            this.lblResizeResultText.Location = new System.Drawing.Point(361, 235);
            this.lblResizeResultText.Name = "lblResizeResultText";
            this.lblResizeResultText.Size = new System.Drawing.Size(135, 13);
            this.lblResizeResultText.TabIndex = 9;
            this.lblResizeResultText.Text = "Размер после архивации";
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Location = new System.Drawing.Point(100, 142);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(74, 13);
            this.lblSavePath.TabIndex = 11;
            this.lblSavePath.Text = "Путь к файлу";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(12, 129);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(82, 39);
            this.btnSaveFile.TabIndex = 12;
            this.btnSaveFile.Text = "Сохранить";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // lblSaveText
            // 
            this.lblSaveText.AutoSize = true;
            this.lblSaveText.Location = new System.Drawing.Point(9, 103);
            this.lblSaveText.Name = "lblSaveText";
            this.lblSaveText.Size = new System.Drawing.Size(317, 13);
            this.lblSaveText.TabIndex = 13;
            this.lblSaveText.Text = "Нажмите сохранить, чтобы указать где сохранить результат";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 174);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 39);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Поехали";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lblTimeText
            // 
            this.lblTimeText.AutoSize = true;
            this.lblTimeText.Location = new System.Drawing.Point(362, 129);
            this.lblTimeText.Name = "lblTimeText";
            this.lblTimeText.Size = new System.Drawing.Size(159, 13);
            this.lblTimeText.TabIndex = 15;
            this.lblTimeText.Text = "Время затраченное на расчет";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(362, 155);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(106, 13);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "потраченное время";
            // 
            // btnOpenResult
            // 
            this.btnOpenResult.Location = new System.Drawing.Point(100, 174);
            this.btnOpenResult.Name = "btnOpenResult";
            this.btnOpenResult.Size = new System.Drawing.Size(82, 39);
            this.btnOpenResult.TabIndex = 17;
            this.btnOpenResult.Text = "открыть результат";
            this.btnOpenResult.UseVisualStyleBackColor = true;
            this.btnOpenResult.Click += new System.EventHandler(this.BtnOpenResult_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 286);
            this.Controls.Add(this.btnOpenResult);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimeText);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSaveText);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.lblResizeResultText);
            this.Controls.Add(this.lblResizeResult);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.lblCountDescription);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnFileChouse);
            this.Controls.Add(this.lblDiscription);
            this.Name = "MainForm";
            this.Text = "Распределитель9000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiscription;
        private System.Windows.Forms.Button btnFileChouse;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblCountDescription;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblResizeResult;
        private System.Windows.Forms.Label lblResizeResultText;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.OpenFileDialog opnFIle;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Label lblSaveText;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTimeText;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnOpenResult;
    }
}

