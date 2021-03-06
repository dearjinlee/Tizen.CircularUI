﻿/*
 * Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://floralicense.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.Generic;
using ElmSharp;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;
using Tizen.Wearable.CircularUI.Forms.Renderer;
using Tizen.Wearable.CircularUI.Forms;

[assembly: ExportRenderer(typeof(Check2TextCell), typeof(Check2TextCellRenderer))]
namespace Tizen.Wearable.CircularUI.Forms.Renderer
{
    public class Check2TextCellRenderer : CheckCellRenderer
    {
		protected Check2TextCellRenderer(string style) : base(style)
		{
		}

		public Check2TextCellRenderer() : this("2text.1icon.1")
		{
			MainPart = "elm.text";
			DetailPart = "elm.text.1";
			CheckBoxPart = "elm.icon";
		}

		protected string DetailPart { get; set; }

		protected override Span OnGetText(Cell cell, string part)
		{
			if (part == MainPart)
			{
				return new Span()
				{
					Text = (cell as CheckCell).Text
				};
			}
			else if (part == DetailPart)
			{
				return new Span()
				{
					Text = (cell as Check2TextCell).Detail
				};
			}
			return null;
		}


		protected override bool OnCellPropertyChanged(Cell cell, string property, Dictionary<string, EvasObject> realizedView)
		{
			if (property == Check2TextCell.DetailProperty.PropertyName)
			{
				return true;
			}
			return base.OnCellPropertyChanged(cell, property, realizedView);
		}
	}
}
