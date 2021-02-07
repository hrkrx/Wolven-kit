using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldStaticLightNode : worldNode
	{
		[Ordinal(0)]  [RED("type")] public CEnum<ELightType> Type { get; set; }
		[Ordinal(1)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(2)]  [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(3)]  [RED("unit")] public CEnum<ELightUnit> Unit { get; set; }
		[Ordinal(4)]  [RED("intensity")] public CFloat Intensity { get; set; }
		[Ordinal(5)]  [RED("rayTracingIntensityScale")] public CFloat RayTracingIntensityScale { get; set; }
		[Ordinal(6)]  [RED("EV")] public CFloat EV { get; set; }
		[Ordinal(7)]  [RED("temperature")] public CFloat Temperature { get; set; }
		[Ordinal(8)]  [RED("lightChannel")] public CEnum<rendLightChannel> LightChannel { get; set; }
		[Ordinal(9)]  [RED("sceneDiffuse")] public CBool SceneDiffuse { get; set; }
		[Ordinal(10)]  [RED("sceneSpecular")] public CBool SceneSpecular { get; set; }
		[Ordinal(11)]  [RED("directional")] public CBool Directional { get; set; }
		[Ordinal(12)]  [RED("roughnessBias")] public CInt8 RoughnessBias { get; set; }
		[Ordinal(13)]  [RED("useInGI")] public CBool UseInGI { get; set; }
		[Ordinal(14)]  [RED("useInEnvProbes")] public CBool UseInEnvProbes { get; set; }
		[Ordinal(15)]  [RED("useInTransparents")] public CBool UseInTransparents { get; set; }
		[Ordinal(16)]  [RED("useInFog")] public CBool UseInFog { get; set; }
		[Ordinal(17)]  [RED("useInParticles")] public CBool UseInParticles { get; set; }
		[Ordinal(18)]  [RED("attenuation")] public CEnum<rendLightAttenuation> Attenuation { get; set; }
		[Ordinal(19)]  [RED("clampAttenuation")] public CBool ClampAttenuation { get; set; }
		[Ordinal(20)]  [RED("group")] public CEnum<rendLightGroup> Group { get; set; }
		[Ordinal(21)]  [RED("areaShape")] public CEnum<EAreaLightShape> AreaShape { get; set; }
		[Ordinal(22)]  [RED("areaTwoSided")] public CBool AreaTwoSided { get; set; }
		[Ordinal(23)]  [RED("spotCapsule")] public CBool SpotCapsule { get; set; }
		[Ordinal(24)]  [RED("sourceRadius")] public CFloat SourceRadius { get; set; }
		[Ordinal(25)]  [RED("capsuleLength")] public CFloat CapsuleLength { get; set; }
		[Ordinal(26)]  [RED("areaRectSideA")] public CFloat AreaRectSideA { get; set; }
		[Ordinal(27)]  [RED("areaRectSideB")] public CFloat AreaRectSideB { get; set; }
		[Ordinal(28)]  [RED("innerAngle")] public CFloat InnerAngle { get; set; }
		[Ordinal(29)]  [RED("outerAngle")] public CFloat OuterAngle { get; set; }
		[Ordinal(30)]  [RED("softness")] public CFloat Softness { get; set; }
		[Ordinal(31)]  [RED("enableLocalShadows")] public CBool EnableLocalShadows { get; set; }
		[Ordinal(32)]  [RED("enableLocalShadowsForceStaticsOnly")] public CBool EnableLocalShadowsForceStaticsOnly { get; set; }
		[Ordinal(33)]  [RED("contactShadows")] public CEnum<rendContactShadowReciever> ContactShadows { get; set; }
		[Ordinal(34)]  [RED("shadowAngle")] public CFloat ShadowAngle { get; set; }
		[Ordinal(35)]  [RED("shadowRadius")] public CFloat ShadowRadius { get; set; }
		[Ordinal(36)]  [RED("shadowFadeDistance")] public CFloat ShadowFadeDistance { get; set; }
		[Ordinal(37)]  [RED("shadowFadeRange")] public CFloat ShadowFadeRange { get; set; }
		[Ordinal(38)]  [RED("shadowSoftnessMode")] public CEnum<ELightShadowSoftnessMode> ShadowSoftnessMode { get; set; }
		[Ordinal(39)]  [RED("iesProfile")] public raRef<CIESDataResource> IesProfile { get; set; }
		[Ordinal(40)]  [RED("flicker")] public rendSLightFlickering Flicker { get; set; }
		[Ordinal(41)]  [RED("envColorGroup")] public CEnum<EEnvColorGroup> EnvColorGroup { get; set; }
		[Ordinal(42)]  [RED("colorGroupSaturation")] public CUInt8 ColorGroupSaturation { get; set; }
		[Ordinal(43)]  [RED("portalAngleCutoff")] public CUInt8 PortalAngleCutoff { get; set; }
		[Ordinal(44)]  [RED("allowDistantLight")] public CBool AllowDistantLight { get; set; }
		[Ordinal(45)]  [RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }

		public worldStaticLightNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
