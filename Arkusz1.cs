using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using Tekla.Structures.Catalogs;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Operation = Tekla.Structures.Model.Operations.Operation;
using Point = Tekla.Structures.Geometry3d.Point;

namespace Komponenty_app
{
	public partial class Arkusz1
	{
		private Model MyModel;
		readonly string CUSTOM_COMPONENTS_PATH = "P:\\TeklaStructuresModels\\XS_FIRM\\Komponenty\\";
		private void Arkusz1_Startup(object sender, System.EventArgs e)
		{
			MyModel = new Model();
		}

		private void Arkusz1_Shutdown(object sender, System.EventArgs e)
		{
		}

		#region Kod wygenerowany przez projektanta VSTO

		/// <summary>
		/// Wymagana metoda obsługi projektanta — nie należy modyfikować 
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InternalStartup()
		{
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button2.Click += new System.EventHandler(this.button2_Click);
			this.button3.Click += new System.EventHandler(this.button3_Click);
			this.button4.Click += new System.EventHandler(this.button4_Click);
			this.button5.Click += new System.EventHandler(this.button5_Click);
			this.button6.Click += new System.EventHandler(this.button6_Click);
			this.button7.Click += new System.EventHandler(this.button7_Click);
			this.button8.Click += new System.EventHandler(this.button8_Click);
			this.button9.Click += new System.EventHandler(this.button9_Click);
			this.button10.Click += new System.EventHandler(this.button10_Click);
			this.button11.Click += new System.EventHandler(this.button11_Click);
			this.button12.Click += new System.EventHandler(this.button12_Click);
			this.button13.Click += new System.EventHandler(this.button13_Click);
			this.button14.Click += new System.EventHandler(this.button14_Click);
			this.button15.Click += new System.EventHandler(this.button15_Click);
			this.button16.Click += new System.EventHandler(this.button16_Click);
			this.button17.Click += new System.EventHandler(this.button17_Click);
			this.button18.Click += new System.EventHandler(this.button18_Click);
			this.button19.Click += new System.EventHandler(this.button19_Click);
			this.button20.Click += new System.EventHandler(this.button20_Click);
			this.button21.Click += new System.EventHandler(this.button21_Click);
			this.button22.Click += new System.EventHandler(this.button22_Click);
			this.button23.Click += new System.EventHandler(this.button23_Click);
			this.button24.Click += new System.EventHandler(this.button24_Click);
			this.button25.Click += new System.EventHandler(this.button25_Click);
			this.button26.Click += new System.EventHandler(this.button26_Click);
			this.button27.Click += new System.EventHandler(this.button27_Click);
			this.button28.Click += new System.EventHandler(this.button28_Click);
			this.button29.Click += new System.EventHandler(this.button29_Click);
			this.button30.Click += new System.EventHandler(this.button30_Click);
			this.button31.Click += new System.EventHandler(this.button31_Click);
			this.button32.Click += new System.EventHandler(this.button32_Click);
			this.button33.Click += new System.EventHandler(this.button33_Click);
			this.button34.Click += new System.EventHandler(this.button34_Click);
			this.button35.Click += new System.EventHandler(this.button35_Click);
			this.button36.Click += new System.EventHandler(this.button36_Click);
			this.button37.Click += new System.EventHandler(this.button37_Click);
			this.button38.Click += new System.EventHandler(this.button38_Click);
			this.button39.Click += new System.EventHandler(this.button39_Click);
			this.button40.Click += new System.EventHandler(this.button40_Click);
			this.button41.Click += new System.EventHandler(this.button41_Click);
			this.button42.Click += new System.EventHandler(this.button42_Click);
			this.button43.Click += new System.EventHandler(this.button43_Click);
			this.button44.Click += new System.EventHandler(this.button44_Click);
			this.button45.Click += new System.EventHandler(this.button45_Click);
			this.button46.Click += new System.EventHandler(this.button46_Click);
			this.button47.Click += new System.EventHandler(this.button47_Click);
			this.button48.Click += new System.EventHandler(this.button48_Click);
			this.button49.Click += new System.EventHandler(this.button49_Click);
			this.button50.Click += new System.EventHandler(this.button50_Click);
			this.button51.Click += new System.EventHandler(this.button51_Click);
			this.button52.Click += new System.EventHandler(this.button52_Click);
			this.button53.Click += new System.EventHandler(this.button53_Click);
			this.button54.Click += new System.EventHandler(this.button54_Click);
			this.Startup += new System.EventHandler(this.Arkusz1_Startup);
			this.Shutdown += new System.EventHandler(this.Arkusz1_Shutdown);

		}

		#endregion

		private bool isExisting(BaseComponent component)
		{
			CatalogHandler catalogHandler = new CatalogHandler();
			if (catalogHandler.GetConnectionStatus())
			{
				ComponentItemEnumerator componentItemEnumerator = catalogHandler.GetComponentItems();
				ComponentItem componentItem;
				while (componentItemEnumerator.MoveNext())
				{
					componentItem = componentItemEnumerator.Current;
					if (component.Name == componentItem.Name)
					{
						return true;
					}
				}
				return false;
			}
			MessageBox.Show("Nie można połączyć z modelem");
			throw new Exception("Nie można połączyć z modelem");
		}

		private void importCustomComponent(BaseComponent component)
		{
			CatalogHandler catalogHandler = new CatalogHandler();
			if (catalogHandler.ImportCustomComponentItems(CUSTOM_COMPONENTS_PATH + component.Name + ".uel"))
			{
				Operation.DisplayPrompt("Importowano komponent " + component.Name);
			}
		}

		private void createConnectionOfTwoParts(string name, int number)
		{
			Connection connection = new Connection();
			connection.Name = name;
			connection.Number = number;
			Picker picker = new Picker();

			try
			{
				connection.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Wybierz element główny"));
				connection.SetSecondaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Wybierz element podrzędny"));
			}
			catch (ApplicationException ex)
			{
				Operation.DisplayPrompt("Przerwano operację");
				return;
			}

			if (number != BaseComponent.CUSTOM_OBJECT_NUMBER)
			{
				connection.Insert();
			}
			else
			{
				try
				{
					if (isExisting(connection))
					{
						connection.Insert();
					}
					else
					{
						importCustomComponent(connection);
						connection.Insert();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie udało się wstawić komponentu", "Error");
				}
			}
			MyModel.CommitChanges();
		}

		private void createDetailWithoutReferencePoint(string name, int number)
		{
			Detail detail = new Detail();
			detail.Name = name;
			detail.Number = number;

			Picker picker = new Picker();
			try
			{
				detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Wybierz element"));
			}
			catch (ApplicationException ex)
			{
				Operation.DisplayPrompt("Przerwano operację");
				return;
			}

			if (number != BaseComponent.CUSTOM_OBJECT_NUMBER)
			{
				detail.Insert();
			}
			else
			{
				try
				{
					if (isExisting(detail))
					{
						detail.Insert();
					}
					else
					{
						importCustomComponent(detail);
						detail.Insert();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie udało się wstawić komponentu", "Error");
				}

			}
			MyModel.CommitChanges();
		}

		private void createDetailWithReferencePoint(string name, int number)
		{
			Detail detail = new Detail();
			detail.Name = name;
			detail.Number = number;
			Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_display_connection_dialog", number.ToString());

			Picker picker = new Picker();
			try
			{
				detail.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Wybierz element"));
				detail.SetReferencePoint(picker.PickPoint("Wybierz punkt"));
			}
			catch (ApplicationException ex)
			{
				Operation.DisplayPrompt("Przerwano operację");
				return;
			}

			if (number != BaseComponent.CUSTOM_OBJECT_NUMBER)
			{
				detail.Class = 99;
				detail.Insert();
			}
			else
			{
				try
				{
					if (isExisting(detail))
					{
						detail.Insert();
					}
					else
					{
						importCustomComponent(detail);
						detail.Insert();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie udało się wstawić komponentu", "Error");
				}
			}
			MyModel.CommitChanges();
		}

		private void createSeamOfTwoParts(string name, int number)
		{
			Seam seam = new Seam();
			seam.Name = name;
			seam.Number = number;

			Picker picker = new Picker();

			try
			{
				seam.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Wybierz element główny"));
				seam.SetSecondaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Wybierz element podrzędny"));
				seam.SetInputPositions(picker.PickPoint("Wybierz punkt"), picker.PickPoint("Wybierz punkt"));
			}
			catch (ApplicationException ex)
			{
				Operation.DisplayPrompt("Przerwano operację");
				return;
			}
			if (number != BaseComponent.CUSTOM_OBJECT_NUMBER)
			{
				seam.Insert();
			}
			else
			{
				try
				{
					if (isExisting(seam))
					{
						seam.Insert();
					}
					else
					{
						importCustomComponent(seam);
						seam.Insert();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie udało się wstawić komponentu", "Error");
				}
			}
			MyModel.CommitChanges();
		}

		private void createSeamOfMultipleParts(string name, int number)
		{
			Seam seam = new Seam();
			seam.Name = name;
			seam.Number = number;

			Picker picker = new Picker();

			try
			{
				seam.SetPrimaryObject(picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Wybierz element główny"));
				ModelObjectEnumerator partsEnumerator = picker.PickObjects(Picker.PickObjectsEnum.PICK_N_OBJECTS, "Wybierz elementy podrzędne");
				ArrayList secondaryParts = new ArrayList();

				foreach (ModelObject modelObject in partsEnumerator)
				{
					secondaryParts.Add(modelObject);
				}
				seam.SetSecondaryObjects(secondaryParts);
				seam.SetInputPositions(picker.PickPoint(), picker.PickPoint());
			}
			catch (ApplicationException ex)
			{
				Operation.DisplayPrompt("Przerwano operację");
				return;
			}
			if (number != BaseComponent.CUSTOM_OBJECT_NUMBER)
			{
				seam.Insert();
			}
			else
			{
				try
				{
					if (isExisting(seam))
					{
						seam.Insert();
					}
					else
					{
						importCustomComponent(seam);
						seam.Insert();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie udało się wstawić komponentu", "Error");
				}
			}
			MyModel.CommitChanges();
		}

		private void createElementOfTwoPoints(string name, int number)
		{
			CustomPart customPart = new CustomPart();
			customPart.Name = name;
			customPart.Number = number;

			Picker picker = new Picker();

			try
			{
				customPart.SetInputPositions(picker.PickPoint("Wybierz punkt"), picker.PickPoint("Wybierz punkt"));
			}
			catch (ApplicationException ex)
			{
				Operation.DisplayPrompt("Przerwano operację");
				return;
			}
			if (number != BaseComponent.CUSTOM_OBJECT_NUMBER)
			{
				customPart.Insert();
			}
			else
			{
				try
				{
					if (isExisting(customPart))
					{
						customPart.Insert();
					}
					else
					{
						importCustomComponent(customPart);
						customPart.Insert();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie udało się wstawić komponentu", "Error");
				}
			}
			MyModel.CommitChanges();
		}

		private void createElementOfOnePoint(string name, int number)
		{
			CustomPart customPart = new CustomPart();
			customPart.Name = name;
			customPart.Number = number;

			Picker picker = new Picker();
			try
			{
				Point startPoint = picker.PickPoint("Wybierz punkt");
				customPart.SetInputPositions(startPoint, startPoint + new Point(0, 0, 1000));
			}
			catch (ApplicationException ex)
			{
				Operation.DisplayPrompt("Przerwano operację");
				return;
			}
			if (number != BaseComponent.CUSTOM_OBJECT_NUMBER)
			{
				customPart.Insert();
			}
			else
			{
				try
				{
					if (isExisting(customPart))
					{
						customPart.Insert();
					}
					else
					{
						importCustomComponent(customPart);
						customPart.Insert();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie udało się wstawić komponentu", "Error");
				}
			}
			MyModel.CommitChanges();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("S_P_T_1000", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("S_P_BS_1001", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("S_P_BS_1002", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("S_P_X_1003", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			createElementOfTwoPoints("S_P_PG_1004", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			createElementOfTwoPoints("S_P_PG_1005", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			createElementOfTwoPoints("S_P_PG_1006", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			createElementOfTwoPoints("S_P_PG_1007", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button9_Click(object sender, EventArgs e)
		{

			Process ExternalProcess = new Process();
			ExternalProcess.StartInfo.FileName = @"P:\TeklaStructuresModels\XS_FIRM\Komponenty\S_P_ST_1008.exe";
			ExternalProcess.Start();
			ExternalProcess.WaitForExit();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Process ExternalProcess = new Process();
			ExternalProcess.StartInfo.FileName = @"P:\TeklaStructuresModels\XS_FIRM\Komponenty\S_P_ST_1009.exe";
			ExternalProcess.Start();
			ExternalProcess.WaitForExit();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("S_P_RR_1010", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button12_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("S_P_SR_1011", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button13_Click(object sender, EventArgs e)
		{
			createElementOfTwoPoints("S_E_PZ_1012", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button14_Click(object sender, EventArgs e)
		{
			createElementOfTwoPoints("S_E_ST_1013", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button15_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("S_P_BP_1014", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button16_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("S_P_ST_1015", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button17_Click(object sender, EventArgs e)
		{
			createDetailWithoutReferencePoint("S_E_SP_1016", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button18_Click(object sender, EventArgs e)
		{
			createSeamOfTwoParts("Z_K_SZ_2000", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button19_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("Z_P_PDl_2001", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button20_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("Z_P_PDp_2002 ", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button21_Click(object sender, EventArgs e)
		{
			createSeamOfTwoParts("Z_P_SZ_2003", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button22_Click(object sender, EventArgs e)
		{
			createDetailWithoutReferencePoint("Z_D_MSO_2004", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button23_Click(object sender, EventArgs e)
		{
			createDetailWithoutReferencePoint("Z_E_SL_2007", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button24_Click(object sender, EventArgs e)
		{
			createDetailWithoutReferencePoint("Z_E_SL_2008", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button25_Click(object sender, EventArgs e)
		{
			createDetailWithoutReferencePoint("Z_E_SL_2009", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button26_Click(object sender, EventArgs e)
		{
			createDetailWithoutReferencePoint("Z_E_SL_2010", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button27_Click(object sender, EventArgs e)
		{
			createDetailWithoutReferencePoint("Z_E_SL_2011", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button28_Click(object sender, EventArgs e)
		{
			createElementOfTwoPoints("Z_E_SL_2012", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button29_Click(object sender, EventArgs e)
		{
			createDetailWithReferencePoint("Z_E_SL_2013", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button30_Click(object sender, EventArgs e)
		{
			createElementOfOnePoint("Z_E_BSP_2014", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button31_Click(object sender, EventArgs e)
		{
			createElementOfOnePoint("Z_E_B_2015", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button32_Click(object sender, EventArgs e)
		{
			createElementOfOnePoint("Z_E_DZ_2016", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button33_Click(object sender, EventArgs e)
		{
			createElementOfOnePoint("Z_E_DZ_2017", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button34_Click(object sender, EventArgs e)
		{
			createElementOfOnePoint("Z_E_MS_2018", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button35_Click(object sender, EventArgs e)
		{
			createElementOfOnePoint("Z_E_MS_2005", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button36_Click(object sender, EventArgs e)
		{
			createElementOfTwoPoints("Z_E_PD_2022", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button37_Click(object sender, EventArgs e)
		{
			createElementOfTwoPoints("Z_E_SL_2023", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button38_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("Z_P_PDl_2024", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button39_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("Z_P_PDp_2025", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button40_Click(object sender, EventArgs e)
		{
			createDetailWithReferencePoint("Z_D_SL_2026", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button41_Click(object sender, EventArgs e)
		{
			createDetailWithoutReferencePoint("Z_D_SL_2027", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button42_Click(object sender, EventArgs e)
		{
			createDetailWithReferencePoint("Z_D_DZ_2028", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button43_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("Z_P_DZ_2029", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button44_Click(object sender, EventArgs e)
		{
			createSeamOfMultipleParts("Z_K_PD_2030", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button45_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("Z_P_DZ_2031", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button46_Click(object sender, EventArgs e)
		{
			createSeamOfMultipleParts("Z_K_SZ_2032", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button47_Click(object sender, EventArgs e)
		{
			createDetailWithReferencePoint("Z_D_MS_2033", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button48_Click(object sender, EventArgs e)
		{
			createDetailWithReferencePoint("Z_D_DZ_2034", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button49_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("Z_P_DZ_2035", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button50_Click(object sender, EventArgs e)
		{
			createSeamOfMultipleParts("Z_K_SZ_2032", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button51_Click(object sender, EventArgs e)
		{
			createConnectionOfTwoParts("Z_P_DZ_2037", BaseComponent.CUSTOM_OBJECT_NUMBER);
		}

		private void button52_Click(object sender, EventArgs e)
		{
			createDetailWithReferencePoint("Żebra", 1003);
		}

		private void button53_Click(object sender, EventArgs e)
		{
			createDetailWithReferencePoint("Detal blachy końcowej", 1002);
		}

		private void button54_Click(object sender, EventArgs e)
		{
			Process ExternalProcess = new Process();
			ExternalProcess.StartInfo.FileName = @"P:\TeklaStructuresModels\XS_FIRM\Komponenty\Auto_Sruby_App.exe";
			ExternalProcess.Start();
			ExternalProcess.WaitForExit();
		}
	}
}