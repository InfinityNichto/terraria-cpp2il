using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Net;

[Cpp2IlInjected.Token(Token = "0x200049B")]
public class NetGroupInfo
{
	[Cpp2IlInjected.Token(Token = "0x2000935")]
	public enum InfoProviderId
	{
		[Cpp2IlInjected.Token(Token = "0x4008ACC")]
		IPAddress,
		[Cpp2IlInjected.Token(Token = "0x4008ACD")]
		Steam
	}

	[Cpp2IlInjected.Token(Token = "0x2000936")]
	private interface INetGroupInfoProvider
	{
		[Cpp2IlInjected.Token(Token = "0x170008A3")]
		InfoProviderId Id
		{
			[Cpp2IlInjected.Token(Token = "0x6004CE7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170008A4")]
		bool HasValidInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6004CE8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CE9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string ProvideInfoNeededToJoin();
	}

	[Cpp2IlInjected.Token(Token = "0x2000937")]
	private class IPAddressInfoProvider : INetGroupInfoProvider
	{
		[Cpp2IlInjected.Token(Token = "0x170008A5")]
		public InfoProviderId Id
		{
			[Cpp2IlInjected.Token(Token = "0x6004CEA")]
			[Cpp2IlInjected.Address(RVA = "0x142B064", Offset = "0x142B064", VA = "0x142B064", Slot = "4")]
			get
			{
				return default(InfoProviderId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008A6")]
		public bool HasValidInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6004CEB")]
			[Cpp2IlInjected.Address(RVA = "0x142B06C", Offset = "0x142B06C", VA = "0x142B06C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CEC")]
		[Cpp2IlInjected.Address(RVA = "0x142B074", Offset = "0x142B074", VA = "0x142B074", Slot = "6")]
		public string ProvideInfoNeededToJoin()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CED")]
		[Cpp2IlInjected.Address(RVA = "0x142AAC8", Offset = "0x142AAC8", VA = "0x142AAC8")]
		public IPAddressInfoProvider()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000938")]
	private class SteamLobbyInfoProvider : INetGroupInfoProvider
	{
		[Cpp2IlInjected.Token(Token = "0x170008A7")]
		public InfoProviderId Id
		{
			[Cpp2IlInjected.Token(Token = "0x6004CEE")]
			[Cpp2IlInjected.Address(RVA = "0x142B0C4", Offset = "0x142B0C4", VA = "0x142B0C4", Slot = "4")]
			get
			{
				return default(InfoProviderId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008A8")]
		public bool HasValidInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6004CEF")]
			[Cpp2IlInjected.Address(RVA = "0x142B0CC", Offset = "0x142B0CC", VA = "0x142B0CC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004CF0")]
		[Cpp2IlInjected.Address(RVA = "0x142B14C", Offset = "0x142B14C", VA = "0x142B14C", Slot = "6")]
		public string ProvideInfoNeededToJoin()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CF1")]
		[Cpp2IlInjected.Address(RVA = "0x142AAD0", Offset = "0x142AAD0", VA = "0x142AAD0")]
		public SteamLobbyInfoProvider()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400654A")]
	private readonly string[] _separatorBetweenInfos;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400654B")]
	private readonly string[] _separatorBetweenIdAndInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400654C")]
	private List<INetGroupInfoProvider> _infoProviders;

	[Cpp2IlInjected.Token(Token = "0x6003391")]
	[Cpp2IlInjected.Address(RVA = "0x142A920", Offset = "0x142A920", VA = "0x142A920")]
	public NetGroupInfo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003392")]
	[Cpp2IlInjected.Address(RVA = "0x142AAD8", Offset = "0x142AAD8", VA = "0x142AAD8")]
	public string ComposeInfo()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003393")]
	[Cpp2IlInjected.Address(RVA = "0x142AEC0", Offset = "0x142AEC0", VA = "0x142AEC0")]
	public Dictionary<InfoProviderId, string> DecomposeInfo(string info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003394")]
	[Cpp2IlInjected.Address(RVA = "0x142AE44", Offset = "0x142AE44", VA = "0x142AE44")]
	private string ConvertToSafeInfo(string text)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003395")]
	[Cpp2IlInjected.Address(RVA = "0x142AFE8", Offset = "0x142AFE8", VA = "0x142AFE8")]
	private string ConvertFromSafeInfo(string text)
	{
		return null;
	}
}
