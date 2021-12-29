
namespace Albaranes_reporte
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturacionDataSet = new Albaranes_reporte.facturacionDataSet();
            this.albaranesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albaranesTableAdapter = new Albaranes_reporte.facturacionDataSetTableAdapters.albaranesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.albaranesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Albaranes_reporte.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(97, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(676, 273);
            this.reportViewer1.TabIndex = 0;
            // 
            // facturacionDataSet
            // 
            this.facturacionDataSet.DataSetName = "facturacionDataSet";
            this.facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albaranesBindingSource
            // 
            this.albaranesBindingSource.DataMember = "albaranes";
            this.albaranesBindingSource.DataSource = this.facturacionDataSet;
            // 
            // albaranesTableAdapter
            // 
            this.albaranesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albaranesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource albaranesBindingSource;
        private facturacionDataSet facturacionDataSet;
        private facturacionDataSetTableAdapters.albaranesTableAdapter albaranesTableAdapter;
    }
}

