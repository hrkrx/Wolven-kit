using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioDroneMetadata : audioCustomEmitterMetadata
	{
		[Ordinal(0)]  [RED("boneName")] public CName BoneName { get; set; }
		[Ordinal(1)]  [RED("engineStart")] public CName EngineStart { get; set; }
		[Ordinal(2)]  [RED("engineStop")] public CName EngineStop { get; set; }
		[Ordinal(3)]  [RED("combatEnter")] public CName CombatEnter { get; set; }
		[Ordinal(4)]  [RED("combatExit")] public CName CombatExit { get; set; }
		[Ordinal(5)]  [RED("targetLost")] public CName TargetLost { get; set; }
		[Ordinal(6)]  [RED("idle")] public CName Idle { get; set; }
		[Ordinal(7)]  [RED("initialReaction")] public CName InitialReaction { get; set; }
		[Ordinal(8)]  [RED("investigationIgnore")] public CName InvestigationIgnore { get; set; }
		[Ordinal(9)]  [RED("noClearShot")] public CName NoClearShot { get; set; }
		[Ordinal(10)]  [RED("targetComplies")] public CName TargetComplies { get; set; }
		[Ordinal(11)]  [RED("lookForIntruder")] public CName LookForIntruder { get; set; }
		[Ordinal(12)]  [RED("droneDestroyed")] public CName DroneDestroyed { get; set; }
		[Ordinal(13)]  [RED("droneDefeated")] public CName DroneDefeated { get; set; }
		[Ordinal(14)]  [RED("commandHolsterWeapon")] public CName CommandHolsterWeapon { get; set; }
		[Ordinal(15)]  [RED("commandLeaveArea")] public CName CommandLeaveArea { get; set; }
		[Ordinal(16)]  [RED("finalWarning")] public CName FinalWarning { get; set; }
		[Ordinal(17)]  [RED("playDistance")] public CFloat PlayDistance { get; set; }
		[Ordinal(18)]  [RED("decorators")] public CArray<CName> Decorators { get; set; }

		public audioDroneMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
