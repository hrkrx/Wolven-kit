using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCameraComponent : entBaseCameraComponent
	{
		[Ordinal(0)]  [RED("animParamFovOverrideWeight")] public CName AnimParamFovOverrideWeight { get; set; }
		[Ordinal(1)]  [RED("animParamFovOverrideValue")] public CName AnimParamFovOverrideValue { get; set; }
		[Ordinal(2)]  [RED("animParamZoomOverrideWeight")] public CName AnimParamZoomOverrideWeight { get; set; }
		[Ordinal(3)]  [RED("animParamZoomOverrideValue")] public CName AnimParamZoomOverrideValue { get; set; }
		[Ordinal(4)]  [RED("animParamZoomWeaponOverrideWeight")] public CName AnimParamZoomWeaponOverrideWeight { get; set; }
		[Ordinal(5)]  [RED("animParamZoomWeaponOverrideValue")] public CName AnimParamZoomWeaponOverrideValue { get; set; }
		[Ordinal(6)]  [RED("animParamdofIntensity")] public CName AnimParamdofIntensity { get; set; }
		[Ordinal(7)]  [RED("animParamdofNearBlur")] public CName AnimParamdofNearBlur { get; set; }
		[Ordinal(8)]  [RED("animParamdofNearFocus")] public CName AnimParamdofNearFocus { get; set; }
		[Ordinal(9)]  [RED("animParamdofFarBlur")] public CName AnimParamdofFarBlur { get; set; }
		[Ordinal(10)]  [RED("animParamdofFarFocus")] public CName AnimParamdofFarFocus { get; set; }
		[Ordinal(11)]  [RED("fovOverrideWeight")] public CFloat FovOverrideWeight { get; set; }
		[Ordinal(12)]  [RED("fovOverrideValue")] public CFloat FovOverrideValue { get; set; }
		[Ordinal(13)]  [RED("zoomOverrideWeight")] public CFloat ZoomOverrideWeight { get; set; }
		[Ordinal(14)]  [RED("zoomOverrideValue")] public CFloat ZoomOverrideValue { get; set; }
		[Ordinal(15)]  [RED("zoomWeaponOverrideWeight")] public CFloat ZoomWeaponOverrideWeight { get; set; }
		[Ordinal(16)]  [RED("zoomWeaponOverrideValue")] public CFloat ZoomWeaponOverrideValue { get; set; }
		[Ordinal(17)]  [RED("animParamWeaponNearPlaneCM")] public CName AnimParamWeaponNearPlaneCM { get; set; }
		[Ordinal(18)]  [RED("animParamWeaponFarPlaneCM")] public CName AnimParamWeaponFarPlaneCM { get; set; }
		[Ordinal(19)]  [RED("animParamWeaponEdgesSharpness")] public CName AnimParamWeaponEdgesSharpness { get; set; }
		[Ordinal(20)]  [RED("animParamWeaponVignetteIntensity")] public CName AnimParamWeaponVignetteIntensity { get; set; }
		[Ordinal(21)]  [RED("animParamWeaponVignetteRadius")] public CName AnimParamWeaponVignetteRadius { get; set; }
		[Ordinal(22)]  [RED("animParamWeaponVignetteCircular")] public CName AnimParamWeaponVignetteCircular { get; set; }
		[Ordinal(23)]  [RED("animParamWeaponBlurIntensity")] public CName AnimParamWeaponBlurIntensity { get; set; }

		public gameCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
