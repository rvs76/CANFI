﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace CANFI
{
    public partial class CANFIUpDown : RichTextBox
    {
        private int _predecimalPlaces = 3;
        private int _decimalPlaces = 3;
        private int _overallplaces;

        private decimal _value;
        private double _increment;

        public event EventHandler ValueChanged;

        public CANFIUpDown()
        {
            InitializeComponent();
            ReadOnly = true;
            this.ValueChanged += this.HandleValueChanged;
            _overallplaces = _decimalPlaces > 0 ? _predecimalPlaces + 1 + _decimalPlaces : _predecimalPlaces;
            UpdateText();
        }


        private void HandleValueChanged(object sender, EventArgs e)
        {
            this.OnTextChanged(e);
        }

        protected virtual void OnLabelsTextChanged(EventArgs e)
        {
            EventHandler handler = this.HandleValueChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void UpdateText(string text)
        {
            // do nothing if nothing changed
            if (this.Text == text)
                return;
            // keep selection
            int selstart = this.SelectionStart;
            int sellen = this.SelectionLength;
            // update text
            this.Text = text + " ";
            this.SelectAll();
            this.SelectionAlignment = HorizontalAlignment.Right;
            // restore selection
            this.Select(selstart, sellen);
        }

        private void UpdateText()
        {
            // keep selection
            int selstart = this.SelectionStart;
            int sellen = this.SelectionLength;
            // update text
            _overallplaces = _decimalPlaces > 0 ? _predecimalPlaces + 1 + _decimalPlaces : _predecimalPlaces;
            string format = "";
            for (int i = 1; i <= _predecimalPlaces; i++)
                format += "0";
            if (_decimalPlaces > 0)
            {
                format += Application.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                for (int i = 1; i <= _decimalPlaces; i++)
                    format += "0";
            }
            string t = _value.ToString(format,Application.CurrentCulture)+" ";
            // do nothing if nothing changed
            if (this.Text == t)
                return;
            this.Text = t;
            this.SelectAll();
            this.SelectionAlignment = HorizontalAlignment.Right;
            // restore selection
            this.Select(selstart,sellen);
            this.ValueChanged(this,new EventArgs());
        }

        [DefaultValue(typeof(double), "0")]
        public decimal Value
        {
            get
            {
                return _value;
            }
            set
            {
                string s = this.Name;
                _value = value;
                if (_value < 0)
                    _value = 0;
                UpdateText();
            }
        }

        [DefaultValue(typeof(int), "3")]
        public int DecimalPlaces
        {
            get
            {
                return _decimalPlaces;
            }
            set
            {
                _decimalPlaces = value;
                if (_decimalPlaces < 0)
                    _decimalPlaces = 0;
                UpdateText();
            }
        }

        [DefaultValue(typeof(int), "3")]
        public int PredecimalPlaces
        {
            get
            {
                return _predecimalPlaces;
            }
            set
            {
                _predecimalPlaces = value;
                if (_predecimalPlaces < 0)
                    _predecimalPlaces = 0;
                UpdateText();
            }
        }

        private bool IsSelectionOnDecimalPoint()
        {
            return (this.Text.Length > 0) && (this.SelectionStart >= this.Text.Length - 1);
        }

        private void MoveSelectionRight()
        {
            if (this.SelectionStart < this.Text.Length)
            {
                // avoid setting selection to decimal separator
                if ((_decimalPlaces > 0) && (this.SelectionStart == _predecimalPlaces - 1))
                    this.SelectionStart += 2;
                else
                    this.SelectionStart++;
            }
        }

        private void MoveSelectionLeft()
        {
            if (this.SelectionStart > 0)
            {
                // avoid setting selection to decimal separator
                if ((_decimalPlaces > 0) && (this.SelectionStart == _predecimalPlaces + 1))
                    this.SelectionStart -= 2;
                else
                    this.SelectionStart--;
            }
        }

        protected override void  OnSelectionChanged(EventArgs e)
        {
 	        base.OnSelectionChanged(e);
            // avoid setting selection by mouse click to decimal separator or end of text
            if (IsSelectionOnDecimalPoint())
                MoveSelectionLeft();
            if ((_decimalPlaces > 0) && (this.SelectionStart == _predecimalPlaces))
                this.SelectionStart--;
            // set selection length always to 1 
            if (this.SelectionLength != 1)
                this.SelectionLength = 1;
            // calculate increment according to offset
            if (this.SelectionStart < _predecimalPlaces)
                _increment = Math.Pow(10, _predecimalPlaces - this.SelectionStart - 1);
            else
                _increment = Math.Pow(10, -(this.SelectionStart - _predecimalPlaces));
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            Value =  Value + (decimal) (e.Delta/120 * _increment);
          
//            base.OnMouseWheel(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                MoveSelectionLeft();
                e.Handled = true;
            }
            if (e.KeyData == Keys.Right)
            {
                MoveSelectionRight();
                e.Handled = true;
            }
            if (e.KeyData == Keys.Down)
            {
                Value = Value - (decimal)_increment;
                e.Handled = true;
            }
            if (e.KeyData == Keys.Up)
            {
                Value = Value + (decimal)_increment;
                e.Handled = true;
            }
            if (e.KeyData == Keys.D0)
            {
                UpdateText(this.Text.Substring(0, this.SelectionStart) + "0" + this.Text.Substring(this.SelectionStart + this.SelectionLength));
                decimal d = 0;
                decimal.TryParse(this.Text, out d);
                this.Value = d;
                MoveSelectionRight();
                e.Handled = true;
            }
            if (e.KeyData == Keys.D1)
            {
                UpdateText(this.Text.Substring(0, this.SelectionStart) + "1" + this.Text.Substring(this.SelectionStart + this.SelectionLength));
                decimal d = 0;
                decimal.TryParse(this.Text, out d);
                this.Value = d;
                MoveSelectionRight();
                e.Handled = true;
            }
            if (e.KeyData == Keys.D2)
            {
                UpdateText(this.Text.Substring(0, this.SelectionStart) + "2" + this.Text.Substring(this.SelectionStart + this.SelectionLength));
                decimal d = 0;
                decimal.TryParse(this.Text, out d);
                this.Value = d;
                MoveSelectionRight();
                e.Handled = true;
            }
            if (e.KeyData == Keys.D3)
            {
                UpdateText(this.Text.Substring(0, this.SelectionStart) + "3" + this.Text.Substring(this.SelectionStart + this.SelectionLength));
                decimal d = 0;
                decimal.TryParse(this.Text, out d);
                this.Value = d;
                MoveSelectionRight();
                e.Handled = true;
            }
            if (e.KeyData == Keys.D4)
            {
                UpdateText(this.Text.Substring(0, this.SelectionStart) + "4" + this.Text.Substring(this.SelectionStart + this.SelectionLength));
                decimal d = 0;
                decimal.TryParse(this.Text, out d);
                this.Value = d;
                MoveSelectionRight();
                e.Handled = true;
            }
            if (e.KeyData == Keys.D5)
            {
                UpdateText(this.Text.Substring(0, this.SelectionStart) + "5" + this.Text.Substring(this.SelectionStart + this.SelectionLength));
                decimal d = 0;
                decimal.TryParse(this.Text, out d);
                this.Value = d;
                MoveSelectionRight();
                e.Handled = true;
            }
            if (e.KeyData == Keys.D6)
            {
                UpdateText(this.Text.Substring(0, this.SelectionStart) + "6" + this.Text.Substring(this.SelectionStart + this.SelectionLength));
                decimal d = 0;
                decimal.TryParse(this.Text, out d);
                this.Value = d;
                MoveSelectionRight();
                e.Handled = true;
            }
            if (e.KeyData == Keys.D7)
            {
                UpdateText(this.Text.Substring(0, this.SelectionStart) + "7" + this.Text.Substring(this.SelectionStart + this.SelectionLength));
                decimal d = 0;
                decimal.TryParse(this.Text, out d);
                this.Value = d;
                MoveSelectionRight();
                e.Handled = true;
            }
            if (e.KeyData == Keys.D8)
            {
                UpdateText(this.Text.Substring(0, this.SelectionStart) + "8" + this.Text.Substring(this.SelectionStart + this.SelectionLength));
                decimal d = 0;
                decimal.TryParse(this.Text, out d);
                this.Value = d;
                MoveSelectionRight();
                e.Handled = true;
            }
            if (e.KeyData == Keys.D9)
            {
                UpdateText(this.Text.Substring(0, this.SelectionStart) + "9" + this.Text.Substring(this.SelectionStart + this.SelectionLength));
                decimal d = 0;
                decimal.TryParse(this.Text, out d);
                this.Value = d;
                MoveSelectionRight();
                e.Handled = true;
            }
            if (e.KeyData == Keys.Delete)
            {
                UpdateText(this.Text.Substring(0, this.SelectionStart) + "0" + this.Text.Substring(this.SelectionStart + this.SelectionLength));
                decimal d = 0;
                decimal.TryParse(this.Text, out d);
                this.Value = d;
                e.Handled = true;
            }
            if (e.KeyData == Keys.Back)
            {
                UpdateText(this.Text.Substring(0, this.SelectionStart) + "0" + this.Text.Substring(this.SelectionStart + this.SelectionLength));
                decimal d = 0;
                decimal.TryParse(this.Text, out d);
                this.Value = d;
                MoveSelectionLeft();
                e.Handled = true;
            }
            base.OnKeyDown(e);
        }
    }
}
