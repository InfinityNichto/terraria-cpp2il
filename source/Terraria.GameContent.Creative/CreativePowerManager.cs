using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x200067F")]
public class CreativePowerManager
{
	[Cpp2IlInjected.Token(Token = "0x2000A65")]
	private class PowerTypeStorage<T> where T : ICreativePower
	{
		[Cpp2IlInjected.Token(Token = "0x4008E6B")]
		public static ushort Id;

		[Cpp2IlInjected.Token(Token = "0x4008E6C")]
		public static string Name;

		[Cpp2IlInjected.Token(Token = "0x60050F3")]
		[Cpp2IlInjected.Address(RVA = "0x163F3FC", Offset = "0x163F3FC", VA = "0x163F3FC")]
		public PowerTypeStorage()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006DB3")]
	private Dictionary<ushort, ICreativePower> _powersById;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006DB4")]
	private Dictionary<string, ICreativePower> _powersByName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006DB5")]
	private ushort _powersCount;

	[Cpp2IlInjected.Token(Token = "0x4006DB6")]
	private const string _powerPermissionsLineHeader = "journeypermission_";

	[Cpp2IlInjected.Token(Token = "0x17000794")]
	public static CreativePowerManager Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6004191")]
		[Cpp2IlInjected.Address(RVA = "0x1082078", Offset = "0x1082078", VA = "0x1082078")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000795")]
	private static bool _initialized
	{
		[Cpp2IlInjected.Token(Token = "0x6004192")]
		[Cpp2IlInjected.Address(RVA = "0x10820F4", Offset = "0x10820F4", VA = "0x10820F4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6004193")]
		[Cpp2IlInjected.Address(RVA = "0x1082170", Offset = "0x1082170", VA = "0x1082170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004194")]
	[Cpp2IlInjected.Address(RVA = "0x10821F0", Offset = "0x10821F0", VA = "0x10821F0")]
	public CreativePowerManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004195")]
	[Cpp2IlInjected.Address(RVA = "0x15A57FC", Offset = "0x15A57FC", VA = "0x15A57FC")]
	public void Register<T>(string nameInServerConfig) where T : ICreativePower, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004196")]
	[Cpp2IlInjected.Address(RVA = "0x15F0098", Offset = "0x15F0098", VA = "0x15F0098")]
	public T GetPower<T>() where T : class, ICreativePower
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004197")]
	[Cpp2IlInjected.Address(RVA = "0x16069D0", Offset = "0x16069D0", VA = "0x16069D0")]
	public ushort GetPowerId<T>() where T : ICreativePower
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6004198")]
	[Cpp2IlInjected.Address(RVA = "0x10822A8", Offset = "0x10822A8", VA = "0x10822A8")]
	public bool TryGetPower(ushort id, out ICreativePower power)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004199")]
	[Cpp2IlInjected.Address(RVA = "0x1082314", Offset = "0x1082314", VA = "0x1082314")]
	public static void TryListingPermissionsFrom(string line)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600419A")]
	[Cpp2IlInjected.Address(RVA = "0x10825B0", Offset = "0x10825B0", VA = "0x10825B0")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600419B")]
	[Cpp2IlInjected.Address(RVA = "0x108285C", Offset = "0x108285C", VA = "0x108285C")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600419C")]
	[Cpp2IlInjected.Address(RVA = "0x1082BBC", Offset = "0x1082BBC", VA = "0x1082BBC")]
	public void SaveToWorld(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600419D")]
	[Cpp2IlInjected.Address(RVA = "0x1082DF0", Offset = "0x1082DF0", VA = "0x1082DF0")]
	public void LoadFromWorld(BinaryReader reader, int versionGameWasLastSavedOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600419E")]
	[Cpp2IlInjected.Address(RVA = "0x1082F58", Offset = "0x1082F58", VA = "0x1082F58")]
	public void ValidateWorld(BinaryReader reader, int versionGameWasLastSavedOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600419F")]
	[Cpp2IlInjected.Address(RVA = "0x10830C0", Offset = "0x10830C0", VA = "0x10830C0")]
	public static void SyncSplitScreenPlayer(int playerIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041A0")]
	[Cpp2IlInjected.Address(RVA = "0x1083150", Offset = "0x1083150", VA = "0x1083150")]
	private void SyncSplitScreenPlayerInternal(int playerIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041A1")]
	[Cpp2IlInjected.Address(RVA = "0x10836CC", Offset = "0x10836CC", VA = "0x10836CC")]
	public void SyncThingsToJoiningPlayer(int playerIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041A2")]
	[Cpp2IlInjected.Address(RVA = "0x1083ABC", Offset = "0x1083ABC", VA = "0x1083ABC")]
	public void SaveToPlayer(Player player, BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041A3")]
	[Cpp2IlInjected.Address(RVA = "0x1083CEC", Offset = "0x1083CEC", VA = "0x1083CEC")]
	public void LoadToPlayer(Player player, BinaryReader reader, int versionGameWasLastSavedOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041A4")]
	[Cpp2IlInjected.Address(RVA = "0x108404C", Offset = "0x108404C", VA = "0x108404C")]
	public void ApplyLoadedDataToPlayer(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041A5")]
	[Cpp2IlInjected.Address(RVA = "0x1083E84", Offset = "0x1083E84", VA = "0x1083E84")]
	public void ResetPowersForPlayer(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041A6")]
	[Cpp2IlInjected.Address(RVA = "0x1084214", Offset = "0x1084214", VA = "0x1084214")]
	public void ResetDataForNewPlayer(Player player)
	{
	}
}
