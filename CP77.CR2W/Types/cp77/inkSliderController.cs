using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkSliderController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("slidingAreaRef")] public inkWidgetReference SlidingAreaRef { get; set; }
		[Ordinal(1)]  [RED("handleRef")] public inkWidgetReference HandleRef { get; set; }
		[Ordinal(2)]  [RED("nextRef")] public inkWidgetReference NextRef { get; set; }
		[Ordinal(3)]  [RED("priorRef")] public inkWidgetReference PriorRef { get; set; }
		[Ordinal(4)]  [RED("direction")] public CEnum<inkESliderDirection> Direction { get; set; }
		[Ordinal(5)]  [RED("autoSizeHandle")] public CBool AutoSizeHandle { get; set; }
		[Ordinal(6)]  [RED("minHandleSize")] public CFloat MinHandleSize { get; set; }
		[Ordinal(7)]  [RED("maxHandleSize")] public CFloat MaxHandleSize { get; set; }
		[Ordinal(8)]  [RED("percentHandleSize")] public CFloat PercentHandleSize { get; set; }
		[Ordinal(9)]  [RED("currentProgress")] public CFloat CurrentProgress { get; set; }
		[Ordinal(10)]  [RED("minimumValue")] public CFloat MinimumValue { get; set; }
		[Ordinal(11)]  [RED("maximumValue")] public CFloat MaximumValue { get; set; }
		[Ordinal(12)]  [RED("step")] public CFloat Step { get; set; }
		[Ordinal(13)]  [RED("SliderInput")] public inkSliderControllerInputCallback SliderInput { get; set; }
		[Ordinal(14)]  [RED("SliderValueChanged")] public inkSliderControllerValueChangeCallback SliderValueChanged { get; set; }
		[Ordinal(15)]  [RED("SliderHandleReleased")] public inkSliderControllerHandleReleasedCallback SliderHandleReleased { get; set; }

		public inkSliderController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
