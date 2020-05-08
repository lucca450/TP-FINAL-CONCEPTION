using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarLocation
{
    public class FormUtilities
    {
        //Permet de vider les controles.
        public static void ResetAllControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }
                else if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
                else if (control is ListView)
                {
                    ListView listView = (ListView)control;
                    listView.Items.Clear();

                }
                else if (control is Panel)
                {
                    foreach (Control p in control.Controls)
                    {
                        if (control is TextBox)
                        {
                            TextBox textBox = (TextBox)control;
                            textBox.Text = null;
                        }
                        if (control is ComboBox)
                        {
                            ComboBox comboBox = (ComboBox)control;
                            if (comboBox.Items.Count > 0)
                                comboBox.SelectedIndex = 0;
                        }
                        if (control is CheckBox)
                        {
                            CheckBox checkBox = (CheckBox)control;
                            checkBox.Checked = false;
                        }
                    }
                }
            }
        }

        //Rends actif les TextBox,ComboBox,DateTimePicker,Button
        public static void SetTextBoxStateEnabled(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
                if (c is TextBox || c is ComboBox || c is DateTimePicker || c is Button)
                    if (!c.Name.Contains("cancelButton"))
                        c.Enabled = true;
        }

        //Permet de remplir le ComboboBox
        public static void FillComboBox(ComboBox typeComboBox, List<string> types)
        {
            foreach (string t in types)
                typeComboBox.Items.Add(t);
        }

        //Rends inactif les TextBox,ComboBox,DateTimePicker et vide ListView
        public static void SetTextBoxStateDisabled(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is TextBox || c is ComboBox || c is DateTimePicker)
                {
                    if (!c.Name.Contains("Code"))
                    {
                        c.Enabled = false;
                        if (!(c is DateTimePicker))
                            c.Text = "";
                    }
                }

                if (c is ListView)
                {
                    ListView listView = (ListView)c;
                    listView.Items.Clear();
                }

                if (c is Panel)
                {
                    foreach (Control p in c.Controls)
                    {
                        if (p is ComboBox || p is TextBox)
                        {
                            p.Enabled = false;
                            p.Text = "";
                        }

                        if (p is DateTimePicker)
                            p.Enabled = false;
                    }
                }
            }
        }

        public static void SetComboBox(ComboBox comboBox, string item)
        {
            comboBox.Items.Add(item);
            comboBox.SelectedItem = item;
        }

        public static void SomethingWentWrongMessageBox(string caption, string text) { MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error); }

        public static void NoItemFound(string v) { MessageBox.Show(v, "Erreur lors de la vérification", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        public static void NoFieldCanBeEmpty() { MessageBox.Show("Tous les champs doivent être remplis", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        public static void SuccessMessageBox(string v) { MessageBox.Show(v, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        public static void ReservationCodeCantBeEmpty() { MessageBox.Show("Le champ 'Numéro de réservation' ne peut pas être vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        public static bool DateVerification(DateTime start, DateTime end) { return start.Date <= end.Date; }

        //Vérifie s'il y a des champs vides
        public static bool IsAnyControlEmpty(Control.ControlCollection controls)
        {
            bool foundOneEmpty = false;

            foreach (Control c in controls)
                if (c is TextBox || c is ComboBox || c is DateTimePicker)
                    if (c.Text.Trim().Equals(""))
                    {
                        foundOneEmpty = true;
                        break;
                    }

            return foundOneEmpty;
        }

        //Vérifie s'il y a des champs vides pour le formulaire de client
        public static bool IsAnyClientControlEmpty(Control.ControlCollection controls)
        {
            bool foundOneEmpty = false;

            foreach (Control c in controls)
                if (c is TextBox)
                {
                    c.Text = c.Text.Trim(' ');
                    if (c.Text.Trim().Equals(""))
                    {
                        foundOneEmpty = true;
                        break;
                    }
                }

            return foundOneEmpty;
        }

        public static bool IsAnyLocationControlEmpty(Control.ControlCollection controls, bool clientHasReservation)
        {
            bool foundOneEmpty = false;

            foreach (Control c in controls)
                if (c is TextBox || c is ComboBox || c is DateTimePicker)
                    if (c.Text.Trim().Equals(""))
                    {
                        if (c.Name == "numeroReservation" && clientHasReservation)
                        {
                            foundOneEmpty = true;
                        }
                        else if (c.Name == "numeroReservation" && !clientHasReservation)
                        {
                            foundOneEmpty = false;
                        }
                        else
                        {
                            foundOneEmpty = true;
                        }
                        break;
                    }

            return foundOneEmpty;
        }
    }
}
