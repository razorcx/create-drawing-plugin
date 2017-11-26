using Tekla.Structures.Plugins;

namespace DrawingPluginExample1
{
	public class DataStructures
	{
		[StructuresField("sampletext")]
		public string SampleText;

		[StructuresField("imagefilename")]
		public string ImageFilename;
	}
}
