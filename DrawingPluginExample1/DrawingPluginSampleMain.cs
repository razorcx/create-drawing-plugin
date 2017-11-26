using System;
using System.Collections.Generic;
using Tekla.Structures.Drawing;
using Tekla.Structures.Drawing.Tools;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Plugins;

namespace DrawingPluginExample1
{
	[Plugin("DrawingPluginExample1")]
	[PluginUserInterface("DrawingPluginExample1.MainForm")]
	public class DrawingPluginSampleMain : DrawingPluginBase
	{
		private DataStructures _data { get; }

		public DrawingPluginSampleMain(DataStructures data)
		{
			_data = data;
		}

		public override bool Run(List<InputDefinition> input)
		{
			try
			{
				var view = InputDefinitionFactory.GetView(input[0]);
				var point = InputDefinitionFactory.GetPoint(input[0]);
				
				var frame = new Frame(FrameTypes.Rectangular, (DrawingColors)0);

				var text = new Text(view, point, $"{_data.SampleText}", 
					new PointPlacing())
				{
					Attributes =
					{
						Frame = frame,
						Angle = 0.0,
						Font = {Color = (DrawingColors)0},
						Alignment = TextAlignment.Left,
					}
				};

				text.Insert();
			}
			catch (Exception ex)
			{
			}

			try
			{
				var view = InputDefinitionFactory.GetView(input[0]);
				var point = InputDefinitionFactory.GetPoint(input[0]);

				var imagePoint = new Point(point);
				imagePoint.Y += 10;

				var image = new Image(view, imagePoint, _data.ImageFilename)
				{
					Attributes =
					{
						Frame = new EmbeddedObjectFrame(LineTypes.UndefinedLine, DrawingColors.Invisible)
					}
				};

				image.Insert();

			}
			catch (Exception ex)
			{
			}

			return true;
		}

		public override List<InputDefinition> DefineInput()
		{
			var drawingHandler = new DrawingHandler();
			var picker = drawingHandler.GetPicker();
			var pick = picker.PickPoint("Pick a point");
			return new List<InputDefinition>()
			{
				InputDefinitionFactory.CreateInputDefinition(pick)
			};
		}
	}
}
