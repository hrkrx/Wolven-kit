using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehicleMetadata : audioCustomEmitterMetadata
	{
		[Ordinal(0)]  [RED("generalData")] public audioVehicleGeneralData GeneralData { get; set; }
		[Ordinal(1)]  [RED("mechanicalData")] public audioVehicleMechanicalData MechanicalData { get; set; }
		[Ordinal(2)]  [RED("wheelData")] public audioVehicleWheelData WheelData { get; set; }
		[Ordinal(3)]  [RED("emitterPositionData")] public audioVehicleEmitterPositionData EmitterPositionData { get; set; }
		[Ordinal(4)]  [RED("minRpm")] public CFloat MinRpm { get; set; }
		[Ordinal(5)]  [RED("maxRpm")] public CFloat MaxRpm { get; set; }
		[Ordinal(6)]  [RED("vehicleCollisionSettings")] public CName VehicleCollisionSettings { get; set; }
		[Ordinal(7)]  [RED("vehicleGridDestructionSettings")] public CName VehicleGridDestructionSettings { get; set; }
		[Ordinal(8)]  [RED("vehiclePartSettings")] public CName VehiclePartSettings { get; set; }
		[Ordinal(9)]  [RED("collisionCooldown")] public CFloat CollisionCooldown { get; set; }
		[Ordinal(10)]  [RED("maxPlayingDistance")] public CFloat MaxPlayingDistance { get; set; }
		[Ordinal(11)]  [RED("dopplerFactor")] public CFloat DopplerFactor { get; set; }
		[Ordinal(12)]  [RED("suspensionSqueekTimeout")] public CFloat SuspensionSqueekTimeout { get; set; }
		[Ordinal(13)]  [RED("exitDelay")] public CFloat ExitDelay { get; set; }
		[Ordinal(14)]  [RED("gearSweeteners")] public CArray<CName> GearSweeteners { get; set; }
		[Ordinal(15)]  [RED("testWheelMaterial")] public CBool TestWheelMaterial { get; set; }
		[Ordinal(16)]  [RED("hasRadioReceiver")] public CBool HasRadioReceiver { get; set; }
		[Ordinal(17)]  [RED("usesPoliceRadioStation")] public CBool UsesPoliceRadioStation { get; set; }
		[Ordinal(18)]  [RED("acousticIsolationFactor")] public CFloat AcousticIsolationFactor { get; set; }
		[Ordinal(19)]  [RED("trafficEmitterMetadata")] public CName TrafficEmitterMetadata { get; set; }
		[Ordinal(20)]  [RED("radioReceiverType")] public CName RadioReceiverType { get; set; }
		[Ordinal(21)]  [RED("matchingStartupRadioStations")] public CArray<CName> MatchingStartupRadioStations { get; set; }
		[Ordinal(22)]  [RED("radioPlaysWhenEngineStartsProbability")] public CFloat RadioPlaysWhenEngineStartsProbability { get; set; }

		public audioVehicleMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
