namespace Komponenty_app
{
	public partial class ThisWorkbook
	{
		private void ThisWorkbook_Startup(object sender, System.EventArgs e)
		{
		}

		private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
		{
		}

		#region Kod wygenerowany przez projektanta VSTO

		/// <summary>
		/// Wymagana metoda obsługi projektanta — nie należy modyfikować 
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InternalStartup()
		{
			this.Startup += new System.EventHandler(ThisWorkbook_Startup);
			this.Shutdown += new System.EventHandler(ThisWorkbook_Shutdown);
		}

		#endregion

	}
}
