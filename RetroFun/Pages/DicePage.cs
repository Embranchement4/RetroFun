﻿using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class DicePage : ObservablePage, ISubscriber
    {
        private bool _IsRegistrationMode;

        public bool IsRegistrationMode
        {
            get => _IsRegistrationMode;
            set
            {
                _IsRegistrationMode = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool IsReceiving => true;

        public DicePage()
        {
            InitializeComponent();
            Bind(DiceRegisterModeCheck, "Checked", nameof(IsRegistrationMode));
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {
            Console.WriteLine("OnOutDiceTrigger: " + IsRegistrationMode);
            if (_IsRegistrationMode)
            {
                RegisterDice(e.Packet.ReadInteger());
                e.IsBlocked = true;
            }
        }
        public void OnLatencyTest(DataInterceptedEventArgs e)
        {
        }
        public void OnUsername(DataInterceptedEventArgs e)
        {
        }

        public void InPurchaseOk(DataInterceptedEventArgs e)
        {
        }

        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
        }
        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {
        }

        public void OnRequestRoomLoad(DataInterceptedEventArgs e)
        {
        }

        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {
        }

        public void InUserEnterRoom(DataInterceptedEventArgs e)
        {
        }

        public void inUserProfile(DataInterceptedEventArgs e)
        {
        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
        }

        public void OnCatalogBuyItem(DataInterceptedEventArgs e)
        {
        }


        private void DiceRegisterMode_CheckedChanged(object sender, EventArgs e)
        {
            if (DiceRegisterModeCheck.Checked)
            {
                DiceRegistered1 = false;
                DiceRegistered2 = false;
                DiceRegistered3 = false;
                DiceRegistered4 = false;
                DiceRegistered5 = false;
                DiceRegistered6 = false;
                RegistrationCompleted = false;
                RegisterDiceSpeak("Registration has been activated.");
                RegisterDiceAsk(1);
            }
            else
            {
                if (!RegistrationCompleted)
                {
                    RegisterDiceSpeak("Registration completed.");
                }
            }
        }

        public void RegisterDice(int NewDice)
        {
            if (!DiceRegistered1)
            {
                DiceRegistered1 = true;
                WriteIDToBox(DiceID1, NewDice.ToString());
                RegisterDiceAsk(2);
                return;
            }
            if (!DiceRegistered2)
            {
                DiceRegistered2 = true;
                WriteIDToBox(DiceID2, NewDice.ToString());
                RegisterDiceAsk(3);
                return;
            }
            if (!DiceRegistered3)
            {
                DiceRegistered3 = true;
                WriteIDToBox(DiceID3, NewDice.ToString());
                RegisterDiceAsk(4);
                return;
            }
            if (!DiceRegistered4)
            {
                DiceRegistered4 = true;
                WriteIDToBox(DiceID4, NewDice.ToString());
                RegisterDiceAsk(5);
                return;
            }
            if (!DiceRegistered5)
            {
                DiceRegistered5 = true;
                WriteIDToBox(DiceID5, NewDice.ToString());
                RegisterDiceAsk(6);
                return;
            }
            if (!DiceRegistered6)
            {
                DiceRegistered6 = true;
                WriteIDToBox(DiceID6, NewDice.ToString());
                RegistrationCompleted = true;
                if (RegistrationCompleted)
                {
                    RegisterDiceSpeak("Registration completed.");
                }
                CheckBoxToggler(DiceRegisterModeCheck, false);
                return;
            }
        }

        private void RollCheckedDices_Click(object sender, EventArgs e)
        {
            if (DiceSelect1.Checked)
            {
                if (int.TryParse(DiceID1.Text, out int result))
                {
                    RollDice(result);
                }
            }
            if (DiceSelect2.Checked)
            {
                if (int.TryParse(DiceID2.Text, out int result))
                {
                    RollDice(result);
                }
            }
            if (DiceSelect3.Checked)
            {
                if (int.TryParse(DiceID3.Text, out int result))
                {
                    RollDice(result);
                }
            }
            if (DiceSelect4.Checked)
            {
                if (int.TryParse(DiceID4.Text, out int result))
                {
                    RollDice(result);
                }
            }
            if (DiceSelect5.Checked)
            {
                if (int.TryParse(DiceID5.Text, out int result))
                {
                    RollDice(result);
                }
            }
            if (DiceSelect6.Checked)
            {
                if (int.TryParse(DiceID6.Text, out int result))
                {
                    RollDice(result);
                }
            }
        }

        private void CloseCheckedDices_Click(object sender, EventArgs e)
        {
            if (DiceSelect1.Checked)
            {
                if (int.TryParse(DiceID1.Text, out int result))
                {
                    CloseDice(result);
                }
            }
            if (DiceSelect2.Checked)
            {
                if (int.TryParse(DiceID2.Text, out int result))
                {
                    CloseDice(result);
                }
            }
            if (DiceSelect3.Checked)
            {
                if (int.TryParse(DiceID3.Text, out int result))
                {
                    CloseDice(result);
                }
            }
            if (DiceSelect4.Checked)
            {
                if (int.TryParse(DiceID4.Text, out int result))
                {
                    CloseDice(result);
                }
            }
            if (DiceSelect5.Checked)
            {
                if (int.TryParse(DiceID5.Text, out int result))
                {
                    CloseDice(result);
                }
            }
            if (DiceSelect6.Checked)
            {
                if (int.TryParse(DiceID6.Text, out int result))
                {
                    CloseDice(result);
                }
            }
        }

        private void ThrowDice1Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DiceID1.Text, out int result))
            {
                RollDice(result);
            }
        }

        private void ThrowDice2Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DiceID2.Text, out int result))
            {
                RollDice(result);
            }
        }

        private void ThrowDice3Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DiceID3.Text, out int result))
            {
                RollDice(result);
            }
        }

        private void ThrowDice4Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DiceID4.Text, out int result))
            {
                RollDice(result);
            }
        }

        private void ThrowDice5Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DiceID5.Text, out int result))
            {
                RollDice(result);
            }
        }

        private void ThrowDice6Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DiceID6.Text, out int result))
            {
                RollDice(result);
            }
        }

        private void CloseDice1Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DiceID1.Text, out int result))
            {
                CloseDice(result);
            }
        }

        private void CloseDice2Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DiceID2.Text, out int result))
            {
                CloseDice(result);
            }
        }

        private void CloseDice3Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DiceID3.Text, out int result))
            {
                CloseDice(result);
            }
        }

        private void CloseDice4Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DiceID4.Text, out int result))
            {
                CloseDice(result);
            }
        }

        private void CloseDice5Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DiceID5.Text, out int result))
            {
                CloseDice(result);
            }
        }

        private void CloseDice6Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DiceID6.Text, out int result))
            {
                CloseDice(result);
            }
        }

        private void UnSelectAllButton_Click(object sender, EventArgs e)
        {
            CheckStatus(false);
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            CheckStatus(true);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            WriteIDToBox(DiceID1, "");
            WriteIDToBox(DiceID2, "");
            WriteIDToBox(DiceID3, "");
            WriteIDToBox(DiceID4, "");
            WriteIDToBox(DiceID5, "");
            WriteIDToBox(DiceID6, "");
            CheckStatus(false);
        }

        public void CheckStatus(bool status)
        {
            CheckBoxToggler(DiceSelect1, status);
            CheckBoxToggler(DiceSelect2, status);
            CheckBoxToggler(DiceSelect3, status);
            CheckBoxToggler(DiceSelect4, status);
            CheckBoxToggler(DiceSelect5, status);
            CheckBoxToggler(DiceSelect6, status);
        }

        private void RollDice(int DiceID)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToServerAsync(Out.TriggerDice, DiceID);
            }
        }

        private void CloseDice(int DiceID)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToServerAsync(Out.CloseDice, DiceID);
            }
        }

        private void RegisterDiceAsk(int DiceNumber)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Registration Dice]: Please Select the dice nr " + DiceNumber.ToString() + ".", 0, 34, 0, -1);
            }
        }

        private void RegisterDiceSpeak(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Registration Dice]: " + text, 0, 34, 0, -1);
            }
        }

        private void WriteIDToBox(TextBox DiceBox, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                DiceBox.Text = text;
            });
        }

        private void CheckBoxToggler(CheckBox box, bool value)
        {
            Invoke((MethodInvoker)delegate
            {
                box.Checked = value;
            });
        }

        private bool DiceRegistered1;
        private bool DiceRegistered2;
        private bool DiceRegistered3;
        private bool DiceRegistered4;
        private bool DiceRegistered5;
        private bool DiceRegistered6;
        private bool RegistrationCompleted;
    }
}