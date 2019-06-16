using System;

namespace PassKeeper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.copyStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCaptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clmCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripShowPass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCopyCaption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCopyLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCopyPass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCopyComment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStripGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.saveAsoolStripMenuItem,
            this.toolStripSeparator5,
            this.выходToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newFileToolStripMenuItem.Text = "Новый";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openFileToolStripMenuItem.Text = "Открыть";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveFileToolStripMenuItem.Text = "Сохранить";
            // 
            // saveAsoolStripMenuItem
            // 
            this.saveAsoolStripMenuItem.Name = "saveAsoolStripMenuItem";
            this.saveAsoolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveAsoolStripMenuItem.Text = "Сохранить как...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(159, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPassToolStripMenuItem,
            this.toolStripSeparator3,
            this.editRowToolStripMenuItem,
            this.addRowToolStripMenuItem,
            this.deleteRowToolStripMenuItem,
            this.toolStripSeparator4,
            this.copyStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // showPassToolStripMenuItem
            // 
            this.showPassToolStripMenuItem.Name = "showPassToolStripMenuItem";
            this.showPassToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.showPassToolStripMenuItem.Text = "Показать пароль";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(164, 6);
            // 
            // editRowToolStripMenuItem
            // 
            this.editRowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editRowToolStripMenuItem.Image")));
            this.editRowToolStripMenuItem.Name = "editRowToolStripMenuItem";
            this.editRowToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.editRowToolStripMenuItem.Text = "Изменить";
            this.editRowToolStripMenuItem.Click += new System.EventHandler(this.editRowToolStripMenuItem_Click);
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addRowToolStripMenuItem.Image")));
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addRowToolStripMenuItem.Text = "Добавить";
            this.addRowToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteRowToolStripMenuItem.Image")));
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteRowToolStripMenuItem.Text = "Удалить";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(164, 6);
            // 
            // copyStripMenuItem
            // 
            this.copyStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCaptionToolStripMenuItem,
            this.copyLoginToolStripMenuItem,
            this.copyPassToolStripMenuItem,
            this.copyCommentToolStripMenuItem});
            this.copyStripMenuItem.Name = "copyStripMenuItem";
            this.copyStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.copyStripMenuItem.Text = "Копировать";
            // 
            // copyCaptionToolStripMenuItem
            // 
            this.copyCaptionToolStripMenuItem.Name = "copyCaptionToolStripMenuItem";
            this.copyCaptionToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // copyLoginToolStripMenuItem
            // 
            this.copyLoginToolStripMenuItem.Name = "copyLoginToolStripMenuItem";
            this.copyLoginToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // copyPassToolStripMenuItem
            // 
            this.copyPassToolStripMenuItem.Name = "copyPassToolStripMenuItem";
            this.copyPassToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // copyCommentToolStripMenuItem
            // 
            this.copyCommentToolStripMenuItem.Name = "copyCommentToolStripMenuItem";
            this.copyCommentToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCodeToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingToolStripMenuItem.Text = "Настройки";
            // 
            // changeCodeToolStripMenuItem
            // 
            this.changeCodeToolStripMenuItem.Name = "changeCodeToolStripMenuItem";
            this.changeCodeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.changeCodeToolStripMenuItem.Text = "Сменить пароль";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayPassToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.viewToolStripMenuItem.Text = "Вид";
            // 
            // displayPassToolStripMenuItem
            // 
            this.displayPassToolStripMenuItem.Name = "displayPassToolStripMenuItem";
            this.displayPassToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.displayPassToolStripMenuItem.Text = "Отображать пароли";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(618, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCaption,
            this.clmLogin,
            this.clmPass,
            this.clmComment});
            this.dataGridView2.ContextMenuStrip = this.contextMenuStripGrid;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 49);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(618, 304);
            this.dataGridView2.TabIndex = 4;
            // 
            // clmCaption
            // 
            this.clmCaption.HeaderText = "Заголовок";
            this.clmCaption.Name = "clmCaption";
            // 
            // clmLogin
            // 
            this.clmLogin.HeaderText = "Имя";
            this.clmLogin.Name = "clmLogin";
            // 
            // clmPass
            // 
            this.clmPass.HeaderText = "Пароль";
            this.clmPass.Name = "clmPass";
            // 
            // clmComment
            // 
            this.clmComment.HeaderText = "Комментарий";
            this.clmComment.Name = "clmComment";
            // 
            // contextMenuStripGrid
            // 
            this.contextMenuStripGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripShowPass,
            this.toolStripSeparator1,
            this.toolStripEdit,
            this.toolStripAdd,
            this.toolStripDelete,
            this.toolStripSeparator2,
            this.toolStripCopy});
            this.contextMenuStripGrid.Name = "contextMenuStripGrid";
            this.contextMenuStripGrid.Size = new System.Drawing.Size(168, 126);
            // 
            // toolStripShowPass
            // 
            this.toolStripShowPass.Name = "toolStripShowPass";
            this.toolStripShowPass.Size = new System.Drawing.Size(167, 22);
            this.toolStripShowPass.Text = "Показать пароль";
            this.toolStripShowPass.Click += new System.EventHandler(this.toolStripShowPass_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEdit.Image")));
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(167, 22);
            this.toolStripEdit.Text = "Изменить";
            this.toolStripEdit.Click += new System.EventHandler(this.toolStripEdit_Click);
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAdd.Image")));
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.Size = new System.Drawing.Size(167, 22);
            this.toolStripAdd.Text = "Добавить";
            this.toolStripAdd.Click += new System.EventHandler(this.toolStripAdd_Click);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDelete.Image")));
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(167, 22);
            this.toolStripDelete.Text = "Удалить";
            this.toolStripDelete.Click += new System.EventHandler(this.toolStripDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripCopy
            // 
            this.toolStripCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCopyCaption,
            this.toolStripCopyLogin,
            this.toolStripCopyPass,
            this.toolStripCopyComment});
            this.toolStripCopy.Name = "toolStripCopy";
            this.toolStripCopy.Size = new System.Drawing.Size(167, 22);
            this.toolStripCopy.Text = "Копировать";
            // 
            // toolStripCopyCaption
            // 
            this.toolStripCopyCaption.Name = "toolStripCopyCaption";
            this.toolStripCopyCaption.Size = new System.Drawing.Size(67, 22);
            // 
            // toolStripCopyLogin
            // 
            this.toolStripCopyLogin.Name = "toolStripCopyLogin";
            this.toolStripCopyLogin.Size = new System.Drawing.Size(67, 22);
            // 
            // toolStripCopyPass
            // 
            this.toolStripCopyPass.Name = "toolStripCopyPass";
            this.toolStripCopyPass.Size = new System.Drawing.Size(67, 22);
            // 
            // toolStripCopyComment
            // 
            this.toolStripCopyComment.Name = "toolStripCopyComment";
            this.toolStripCopyComment.Size = new System.Drawing.Size(67, 22);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 353);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = " PassKeeper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStripGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripCopy;
        private System.Windows.Forms.ToolStripMenuItem editRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowPass;
        private System.Windows.Forms.ToolStripMenuItem toolStripEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripCopyCaption;
        private System.Windows.Forms.ToolStripMenuItem toolStripCopyLogin;
        private System.Windows.Forms.ToolStripMenuItem toolStripCopyPass;
        private System.Windows.Forms.ToolStripMenuItem toolStripCopyComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComment;
        private System.Windows.Forms.ToolStripMenuItem showPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem copyStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCaptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

