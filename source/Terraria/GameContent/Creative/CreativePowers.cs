using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.Localization;
using Terraria.Net;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A36")]
	public class CreativePowers
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004CA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8BC434", Offset = "0x8BC434", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CreativePowers()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A37")]
		public abstract class APerPlayerTogglePower : ICreativePower, IOnPlayerJoining
		{
			[global::Cpp2ILInjected.Token(Token = "0x1700087B")]
			public ushort PowerId
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CAA")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BC43C", Offset = "0x8BC43C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CAB")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BC444", Offset = "0x8BC444", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700087C")]
			public string ServerConfigName
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CAC")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BC44C", Offset = "0x8BC44C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CAD")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BC454", Offset = "0x8BC454", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700087D")]
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CAE")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BC45C", Offset = "0x8BC45C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CAF")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BC464", Offset = "0x8BC464", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700087E")]
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CB0")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BC46C", Offset = "0x8BC46C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CB1")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BC474", Offset = "0x8BC474", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC47C", Offset = "0x8BC47C", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "GetValue", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "GetSelected", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ResetEffects", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GrabItems", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItemGrabRange", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.GodmodePower), Member = "Save", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(BinaryWriter)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.GodmodePower), Member = "ApplyLoadedDataToOutOfPlayerFields", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.FarPlacementRangePower), Member = "Save", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(BinaryWriter)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.FarPlacementRangePower), Member = "ApplyLoadedDataToOutOfPlayerFields", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "IndexInRange", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"T[]",
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool IsEnabledForPlayer(int playerIndex)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC520", Offset = "0x8BC520", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "SetEnabledState", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC648", Offset = "0x8BC648", Length = "0x1C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "op_Implicit", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(BitsByte))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "SetEnabledState", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private void Deserialize_SyncEveryone(BinaryReader reader, int userId)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CB5")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC80C", Offset = "0x8BC80C", Length = "0x158")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "DeserializeNetMessage", MemberParameters = new object[]
			{
				typeof(BinaryReader),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "Deserialize_SyncEveryone", MemberParameters = new object[]
			{
				typeof(BinaryReader),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
			{
				typeof(NetPacket),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public void SetEnabledState(int playerIndex, bool state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC964", Offset = "0x8BC964", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void DebugCall()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC968", Offset = "0x8BC968", Length = "0x164")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "button_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.GodmodePower), Member = "ApplyLoadedDataToOutOfPlayerFields", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.FarPlacementRangePower), Member = "ApplyLoadedDataToOutOfPlayerFields", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal void RequestUse()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BCACC", Offset = "0x8BCACC", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CB9")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BCB00", Offset = "0x8BCB00", Length = "0x1D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "op_Implicit", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(BitsByte))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
			{
				typeof(NetPacket),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public void OnPlayerJoining(int playerIndex)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CBA")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BCCD0", Offset = "0x8BCCD0", Length = "0x1F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreatePersonalPowerStrip", ReturnType = typeof(List<UIElement>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "CreateToggleButton", MemberParameters = new object[] { typeof(CreativePowerUIElementRequestInfo) }, ReturnType = typeof(GroupOptionButton<bool>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "UpdateUnlockStateByPower", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(UIElement),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "GetIconImage", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(UIImageFramed))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CBB")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BCEC4", Offset = "0x8BCEC4", Length = "0x238")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<>), Member = "get_IsSelected", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddDescriptionIfNeeded", MemberParameters = new object[]
			{
				typeof(ref string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddUnlockTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ref string),
				typeof(bool),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddPermissionTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			private void button_OnUpdate(UIElement affectedElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CBC")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD0FC", Offset = "0x8BD0FC", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "RequestUse", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void button_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CBD")]
			public abstract bool GetIsUnlocked();

			[global::Cpp2ILInjected.Token(Token = "0x6004CBE")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD1B8", Offset = "0x8BD1B8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.GodmodePower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.FarPlacementRangePower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			protected APerPlayerTogglePower()
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400866A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ushort <PowerId>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400866B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string <ServerConfigName>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400866C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400866D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			[global::Cpp2ILInjected.Token(Token = "0x400866E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal string _powerNameKey;

			[global::Cpp2ILInjected.Token(Token = "0x400866F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal Point _iconLocation;

			[global::Cpp2ILInjected.Token(Token = "0x4008670")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal bool _defaultToggleState;

			[global::Cpp2ILInjected.Token(Token = "0x4008671")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private bool[] _perPlayerIsEnabled;

			[global::Cpp2ILInjected.Token(Token = "0x2000A38")]
			private enum SubMessageType : byte
			{
				[global::Cpp2ILInjected.Token(Token = "0x4008673")]
				SyncEveryone,
				[global::Cpp2ILInjected.Token(Token = "0x4008674")]
				SyncOnePlayer
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A39")]
		public abstract class APerPlayerSliderPower : ICreativePower, IOnPlayerJoining, IProvideSliderElement, IPowerSubcategoryElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x1700087F")]
			public ushort PowerId
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CBF")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BD210", Offset = "0x8BD210", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CC0")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BD218", Offset = "0x8BD218", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000880")]
			public string ServerConfigName
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CC1")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BD220", Offset = "0x8BD220", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CC2")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BD228", Offset = "0x8BD228", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000881")]
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CC3")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BD230", Offset = "0x8BD230", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CC4")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BD238", Offset = "0x8BD238", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000882")]
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CC5")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BD240", Offset = "0x8BD240", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CC6")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BD248", Offset = "0x8BD248", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CC7")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD250", Offset = "0x8BD250", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SlimeRainSpawns", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SpawnNPC", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "IndexInRange", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(float[]),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool GetRemappedSliderValueFor(int playerIndex, out float value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CC8")]
			public abstract float RemapSliderValueToPowerValue(float sliderValue);

			[global::Cpp2ILInjected.Token(Token = "0x6004CC9")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD310", Offset = "0x8BD310", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CCA")]
			internal abstract void UpdateInfoFromSliderValueCache();

			[global::Cpp2ILInjected.Token(Token = "0x6004CCB")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD43C", Offset = "0x8BD43C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CCC")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD474", Offset = "0x8BD474", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public void DebugCall()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CCD")]
			public abstract UIElement ProvideSlider();

			[global::Cpp2ILInjected.Token(Token = "0x6004CCE")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD598", Offset = "0x8BD598", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "GetValue", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "GetStringValue", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "SetValueGamepad", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "UpdateSliderAndShowMultiplierMouseOver", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal float GetSliderValue()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CCF")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD60C", Offset = "0x8BD60C", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "SetValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep), Member = "SetSpawnRate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "topText_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "middleText_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "bottomText_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal void SetValueKeyboard(float value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD6D4", Offset = "0x8BD6D4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "GetSliderValue", ReturnType = typeof(float))]
			internal void SetValueGamepad()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD6D8", Offset = "0x8BD6D8", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "ApplyLoadedDataToOutOfPlayerFields", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void PushChangeAndSetSlider(float value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD910", Offset = "0x8BD910", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "CreateCategoryButton", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				typeof(CreativePowerUIElementRequestInfo),
				"T",
				"T"
			}, ReturnType = "Terraria.GameContent.UI.Elements.GroupOptionButton`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "UpdateUnlockStateByPower", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(UIElement),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "GetIconImage", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(UIImageFramed))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BDA38", Offset = "0x8BDA38", Length = "0x224")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<int>), Member = "get_IsSelected", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddDescriptionIfNeeded", MemberParameters = new object[]
			{
				typeof(ref string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddUnlockTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ref string),
				typeof(bool),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddPermissionTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			private void categoryButton_OnUpdate(UIElement affectedElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BDC5C", Offset = "0x8BDC5C", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "SetValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep), Member = "SetSpawnRate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "CompareTo", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "PushChange", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void AttemptPushingChange()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD7A8", Offset = "0x8BD7A8", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "AttemptPushingChange", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal void PushChange(float newSliderValue)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CD6")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BDCE8", Offset = "0x8BDCE8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public virtual void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CD7")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BDD40", Offset = "0x8BDD40", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public virtual void ResetForPlayer(int playerIndex)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BDDC8", Offset = "0x8BDDC8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void OnPlayerJoining(int playerIndex)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CD9")]
			public abstract bool GetIsUnlocked();

			[global::Cpp2ILInjected.Token(Token = "0x6004CDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BDDD8", Offset = "0x8BDDD8", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			protected APerPlayerSliderPower()
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008675")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ushort <PowerId>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008676")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string <ServerConfigName>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008677")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008678")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			[global::Cpp2ILInjected.Token(Token = "0x4008679")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal Point _iconLocation;

			[global::Cpp2ILInjected.Token(Token = "0x400867A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal float _sliderCurrentValueCache;

			[global::Cpp2ILInjected.Token(Token = "0x400867B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal string _powerNameKey;

			[global::Cpp2ILInjected.Token(Token = "0x400867C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			internal float[] _cachePerPlayer;

			[global::Cpp2ILInjected.Token(Token = "0x400867D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			internal float _sliderDefaultValue;

			[global::Cpp2ILInjected.Token(Token = "0x400867E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			private float _currentTargetValue;

			[global::Cpp2ILInjected.Token(Token = "0x400867F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private bool _needsToCommitChange;

			[global::Cpp2ILInjected.Token(Token = "0x4008680")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private DateTime _nextTimeWeCanPush;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A3A")]
		public abstract class ASharedButtonPower : ICreativePower
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000883")]
			public ushort PowerId
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CDB")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BDE68", Offset = "0x8BDE68", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CDC")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BDE70", Offset = "0x8BDE70", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000884")]
			public string ServerConfigName
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CDD")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BDE78", Offset = "0x8BDE78", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CDE")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BDE80", Offset = "0x8BDE80", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000885")]
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CDF")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BDE88", Offset = "0x8BDE88", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CE0")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BDE90", Offset = "0x8BDE90", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000886")]
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CE1")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BDE98", Offset = "0x8BDE98", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CE2")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BDEA0", Offset = "0x8BDEA0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BDEA8", Offset = "0x8BDEA8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public ASharedButtonPower()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BDED0", Offset = "0x8BDED0", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "OpenUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedButtonPower), Member = "button_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void RequestUse()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BDF78", Offset = "0x8BDF78", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CE6")]
			internal abstract void UsePower();

			[global::Cpp2ILInjected.Token(Token = "0x6004CE7")]
			internal abstract void OnCreation();

			[global::Cpp2ILInjected.Token(Token = "0x6004CE8")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BE034", Offset = "0x8BE034", Length = "0x1CC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreateTimePowerStrip", ReturnType = typeof(List<UIElement>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "CreateSimpleButton", MemberParameters = new object[] { typeof(CreativePowerUIElementRequestInfo) }, ReturnType = typeof(GroupOptionButton<bool>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "UpdateUnlockStateByPower", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(UIElement),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "GetIconImage", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(UIImageFramed))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BE200", Offset = "0x8BE200", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddDescriptionIfNeeded", MemberParameters = new object[]
			{
				typeof(ref string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddUnlockTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ref string),
				typeof(bool),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddPermissionTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void button_OnUpdate(UIElement affectedElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BE348", Offset = "0x8BE348", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedButtonPower), Member = "RequestUse", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void button_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CEB")]
			public abstract bool GetIsUnlocked();

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008681")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ushort <PowerId>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008682")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string <ServerConfigName>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008683")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008684")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			[global::Cpp2ILInjected.Token(Token = "0x4008685")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal Point _iconLocation;

			[global::Cpp2ILInjected.Token(Token = "0x4008686")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal string _powerNameKey;

			[global::Cpp2ILInjected.Token(Token = "0x4008687")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal string _descriptionKey;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A3B")]
		public abstract class ASharedTogglePower : ICreativePower, IOnPlayerJoining
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000887")]
			public ushort PowerId
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CEC")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BE3EC", Offset = "0x8BE3EC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CED")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BE3F4", Offset = "0x8BE3F4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000888")]
			public string ServerConfigName
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CEE")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BE3FC", Offset = "0x8BE3FC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CEF")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BE404", Offset = "0x8BE404", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000889")]
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CF0")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BE40C", Offset = "0x8BE40C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CF1")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BE414", Offset = "0x8BE414", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700088A")]
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CF2")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BE41C", Offset = "0x8BE41C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CF3")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BE424", Offset = "0x8BE424", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700088B")]
			public bool Enabled
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CF4")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BE42C", Offset = "0x8BE42C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004CF5")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BE434", Offset = "0x8BE434", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CF6")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BE440", Offset = "0x8BE440", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetPowerInfo(bool enabled)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CF7")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BE44C", Offset = "0x8BE44C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CF8")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BE454", Offset = "0x8BE454", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
			{
				typeof(NetPacket),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void OnPlayerJoining(int playerIndex)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BE530", Offset = "0x8BE530", Length = "0x180")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
			{
				typeof(NetPacket),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CFA")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BE6B0", Offset = "0x8BE6B0", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep), Member = "SetTime", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "button_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void RequestUse()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BE784", Offset = "0x8BE784", Length = "0x1F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreateMainPowerStrip", ReturnType = typeof(List<UIElement>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreateTimePowerStrip", ReturnType = typeof(List<UIElement>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreateWeatherPowerStrip", ReturnType = typeof(List<UIElement>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "CreateToggleButton", MemberParameters = new object[] { typeof(CreativePowerUIElementRequestInfo) }, ReturnType = typeof(GroupOptionButton<bool>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "UpdateUnlockStateByPower", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(UIElement),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BE978", Offset = "0x8BE978", Length = "0x234")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<>), Member = "get_IsSelected", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddDescriptionIfNeeded", MemberParameters = new object[]
			{
				typeof(ref string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddUnlockTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ref string),
				typeof(bool),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddPermissionTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			private void button_OnUpdate(UIElement affectedElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BEBAC", Offset = "0x8BEBAC", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedTogglePower), Member = "RequestUse", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void button_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004CFE")]
			internal abstract void CustomizeButton(UIElement button);

			[global::Cpp2ILInjected.Token(Token = "0x6004CFF")]
			internal abstract string GetButtonTextKey();

			[global::Cpp2ILInjected.Token(Token = "0x6004D00")]
			public abstract bool GetIsUnlocked();

			[global::Cpp2ILInjected.Token(Token = "0x6004D01")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BEC50", Offset = "0x8BEC50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected ASharedTogglePower()
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008688")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ushort <PowerId>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008689")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string <ServerConfigName>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400868A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400868B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400868C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private bool <Enabled>k__BackingField;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A3C")]
		public abstract class ASharedSliderPower : ICreativePower, IOnPlayerJoining, IProvideSliderElement, IPowerSubcategoryElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x1700088C")]
			public ushort PowerId
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D02")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BEC58", Offset = "0x8BEC58", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D03")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BEC60", Offset = "0x8BEC60", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700088D")]
			public string ServerConfigName
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D04")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BEC68", Offset = "0x8BEC68", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D05")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BEC70", Offset = "0x8BEC70", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700088E")]
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D06")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BEC78", Offset = "0x8BEC78", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D07")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BEC80", Offset = "0x8BEC80", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700088F")]
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D08")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BEC88", Offset = "0x8BEC88", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D09")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BEC90", Offset = "0x8BEC90", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BEC98", Offset = "0x8BEC98", Length = "0x19C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
			{
				typeof(NetPacket),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D0B")]
			internal abstract void UpdateInfoFromSliderValueCache();

			[global::Cpp2ILInjected.Token(Token = "0x6004D0C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BEE34", Offset = "0x8BEE34", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D0D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BEE6C", Offset = "0x8BEE6C", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void DebugCall()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D0E")]
			public abstract UIElement ProvideSlider();

			[global::Cpp2ILInjected.Token(Token = "0x6004D0F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BEF3C", Offset = "0x8BEF3C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "WindBackingHandler", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Slider_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "RainBackingHandler", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Slider_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "DifficultyBackingHandler", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Slider_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "GetValue", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueGamepad", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal float GetSliderValue()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D10")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BEFC0", Offset = "0x8BEFC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal virtual float GetSliderValueInner()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D11")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BEFC8", Offset = "0x8BEFC8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "WindBackingHandler", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Slider_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "RainBackingHandler", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Slider_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "DifficultyBackingHandler", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Slider_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "SetValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			internal void SetValueKeyboard(float value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D12")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF024", Offset = "0x8BF024", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyTimeRate), Member = "bottomText_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyTimeRate), Member = "middleText_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyTimeRate), Member = "topText_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.DifficultySliderPower), Member = "Click_Master", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.DifficultySliderPower), Member = "Click_Expert", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.DifficultySliderPower), Member = "Click_Normal", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.DifficultySliderPower), Member = "Click_Journey", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyWindDirectionAndStrength), Member = "topText_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyWindDirectionAndStrength), Member = "bottomText_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyWindDirectionAndStrength), Member = "middleText_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyRainPower), Member = "topText_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyRainPower), Member = "middleText_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyRainPower), Member = "bottomText_OnClick", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal void SetValueKeyboardForced(float value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D13")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF0D0", Offset = "0x8BF0D0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "GetSliderValue", ReturnType = typeof(float))]
			internal void SetValueGamepad()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D14")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF0D4", Offset = "0x8BF0D4", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "CreateCategoryButton", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				typeof(CreativePowerUIElementRequestInfo),
				"T",
				"T"
			}, ReturnType = "Terraria.GameContent.UI.Elements.GroupOptionButton`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "UpdateUnlockStateByPower", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(UIElement),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "GetIconImage", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(UIImageFramed))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D15")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF1FC", Offset = "0x8BF1FC", Length = "0x224")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<int>), Member = "get_IsSelected", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddDescriptionIfNeeded", MemberParameters = new object[]
			{
				typeof(ref string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddUnlockTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ref string),
				typeof(bool),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddPermissionTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			private void categoryButton_OnUpdate(UIElement affectedElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D16")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF420", Offset = "0x8BF420", Length = "0x14C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "WindBackingHandler", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Slider_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "RainBackingHandler", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Slider_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "DifficultyBackingHandler", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Slider_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "SetValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "CompareTo", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public void AttemptPushingChange()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D17")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF56C", Offset = "0x8BF56C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public virtual void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D18")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF574", Offset = "0x8BF574", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(int)
			}, ReturnType = typeof(NetPacket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
			{
				typeof(NetPacket),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void OnPlayerJoining(int playerIndex)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D19")]
			public abstract bool GetIsUnlocked();

			[global::Cpp2ILInjected.Token(Token = "0x6004D1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF65C", Offset = "0x8BF65C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyTimeRate), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.DifficultySliderPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyWindDirectionAndStrength), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyRainPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			protected ASharedSliderPower()
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400868D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ushort <PowerId>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400868E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string <ServerConfigName>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400868F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008690")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			[global::Cpp2ILInjected.Token(Token = "0x4008691")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal Point _iconLocation;

			[global::Cpp2ILInjected.Token(Token = "0x4008692")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal float _sliderCurrentValueCache;

			[global::Cpp2ILInjected.Token(Token = "0x4008693")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal string _powerNameKey;

			[global::Cpp2ILInjected.Token(Token = "0x4008694")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			internal bool _syncToJoiningPlayers;

			[global::Cpp2ILInjected.Token(Token = "0x4008695")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
			internal float _currentTargetValue;

			[global::Cpp2ILInjected.Token(Token = "0x4008696")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private bool _needsToCommitChange;

			[global::Cpp2ILInjected.Token(Token = "0x4008697")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private DateTime _nextTimeWeCanPush;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A3D")]
		public class GodmodePower : CreativePowers.APerPlayerTogglePower, IPersistentPerPlayerContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004D1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF6C8", Offset = "0x8BF6C8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public GodmodePower()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF754", Offset = "0x8BF754", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF75C", Offset = "0x8BF75C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "IsEnabledForPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void Save(Player player, BinaryWriter writer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF7DC", Offset = "0x8BF7DC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void ResetDataForNewPlayer(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF7EC", Offset = "0x8BF7EC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D20")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF81C", Offset = "0x8BF81C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "IsEnabledForPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "RequestUse", ReturnType = typeof(void))]
			public void ApplyLoadedDataToOutOfPlayerFields(Player player)
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A3E")]
		public class FarPlacementRangePower : CreativePowers.APerPlayerTogglePower, IPersistentPerPlayerContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004D21")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF860", Offset = "0x8BF860", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public FarPlacementRangePower()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D22")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF928", Offset = "0x8BF928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D23")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF930", Offset = "0x8BF930", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "IsEnabledForPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void Save(Player player, BinaryWriter writer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D24")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF9B0", Offset = "0x8BF9B0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void ResetDataForNewPlayer(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D25")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF9C0", Offset = "0x8BF9C0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D26")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF9F0", Offset = "0x8BF9F0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "IsEnabledForPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "RequestUse", ReturnType = typeof(void))]
			public void ApplyLoadedDataToOutOfPlayerFields(Player player)
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A3F")]
		public class StartDayImmediately : CreativePowers.ASharedButtonPower
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004D27")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFA34", Offset = "0x8BFA34", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SkipToTime", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal override void UsePower()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D28")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFAB4", Offset = "0x8BFAB4", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal override void OnCreation()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D29")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFB5C", Offset = "0x8BFB5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D2A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFB64", Offset = "0x8BFB64", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public StartDayImmediately()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A40")]
		public class StartNightImmediately : CreativePowers.ASharedButtonPower
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004D2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFB8C", Offset = "0x8BFB8C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SkipToTime", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal override void UsePower()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFC0C", Offset = "0x8BFC0C", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal override void OnCreation()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFCB4", Offset = "0x8BFCB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFCBC", Offset = "0x8BFCBC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public StartNightImmediately()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A41")]
		public class StartNoonImmediately : CreativePowers.ASharedButtonPower
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004D2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFCE4", Offset = "0x8BFCE4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SkipToTime", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal override void UsePower()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D30")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFD64", Offset = "0x8BFD64", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal override void OnCreation()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D31")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFE0C", Offset = "0x8BFE0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D32")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFE14", Offset = "0x8BFE14", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public StartNoonImmediately()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A42")]
		public class StartMidnightImmediately : CreativePowers.ASharedButtonPower
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004D33")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFE3C", Offset = "0x8BFE3C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SkipToTime", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal override void UsePower()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D34")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFEBC", Offset = "0x8BFEBC", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal override void OnCreation()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D35")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFF64", Offset = "0x8BFF64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D36")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFF6C", Offset = "0x8BFF6C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public StartMidnightImmediately()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A43")]
		public class ModifyTimeRate : CreativePowers.ASharedSliderPower, IPersistentPerWorldContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000890")]
			public int TargetTimeRate
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D37")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BFF94", Offset = "0x8BFF94", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D38")]
				[global::Cpp2ILInjected.Address(RVA = "0x8BFF9C", Offset = "0x8BFF9C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D39")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFFA4", Offset = "0x8BFFA4", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public ModifyTimeRate()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0030", Offset = "0x8C0030", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D3B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0040", Offset = "0x8C0040", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Remap", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal override void UpdateInfoFromSliderValueCache()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D3C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0174", Offset = "0x8C0174", Length = "0x590")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "CreateSlider", MemberParameters = new object[]
			{
				typeof(Func<float>),
				typeof(Action<float>),
				typeof(Action)
			}, ReturnType = typeof(UIVerticalSlider))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
			public override UIElement ProvideSlider()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D3D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0704", Offset = "0x8C0704", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D3E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0734", Offset = "0x8C0734", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D3F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0764", Offset = "0x8C0764", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D40")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C07A0", Offset = "0x8C07A0", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D41")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0864", Offset = "0x8C0864", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D42")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0928", Offset = "0x8C0928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D43")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0930", Offset = "0x8C0930", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(BinaryWriter writer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D44")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C094C", Offset = "0x8C094C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D45")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0988", Offset = "0x8C0988", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D46")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C099C", Offset = "0x8C099C", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddPermissionTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008698")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private int <TargetTimeRate>k__BackingField;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A44")]
		public class DifficultySliderPower : CreativePowers.ASharedSliderPower, IPersistentPerWorldContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000891")]
			public float StrengthMultiplierToGiveNPCs
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D47")]
				[global::Cpp2ILInjected.Address(RVA = "0x8C0AB8", Offset = "0x8C0AB8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D48")]
				[global::Cpp2ILInjected.Address(RVA = "0x8C0AC0", Offset = "0x8C0AC0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D49")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0AC8", Offset = "0x8C0AC8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public DifficultySliderPower()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0B54", Offset = "0x8C0B54", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0B68", Offset = "0x8C0B68", Length = "0x158")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Remap", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal override void UpdateInfoFromSliderValueCache()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0CC0", Offset = "0x8C0CC0", Length = "0x4FC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "CreateSlider", MemberParameters = new object[]
			{
				typeof(Func<float>),
				typeof(Action<float>),
				typeof(Action)
			}, ReturnType = typeof(UIVerticalSlider))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.DifficultySliderPower), Member = "AddIndication", MemberParameters = new object[]
			{
				typeof(UIPanel),
				typeof(float),
				typeof(string),
				typeof(string),
				typeof(UIElement.ElementEvent),
				typeof(UIElement.MouseEvent)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
			public override UIElement ProvideSlider()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D4D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1438", Offset = "0x8C1438", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void Click_Master(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D4E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1474", Offset = "0x8C1474", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void Click_Expert(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C14A8", Offset = "0x8C14A8", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void Click_Normal(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D50")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C14DC", Offset = "0x8C14DC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void Click_Journey(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D51")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C11BC", Offset = "0x8C11BC", Length = "0x27C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.DifficultySliderPower), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImage), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			private static void AddIndication(UIPanel panel, float yAnchor, string indicationText, string iconImagePath, UIElement.ElementEvent updateEvent, UIElement.MouseEvent clickEvent)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D52")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C150C", Offset = "0x8C150C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private static void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D53")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C152C", Offset = "0x8C152C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private static void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D54")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C154C", Offset = "0x8C154C", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void MouseOver_Journey(UIElement affectedElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D55")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1608", Offset = "0x8C1608", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void MouseOver_Normal(UIElement affectedElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D56")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C16C4", Offset = "0x8C16C4", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void MouseOver_Expert(UIElement affectedElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D57")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1780", Offset = "0x8C1780", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void MouseOver_Master(UIElement affectedElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D58")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C183C", Offset = "0x8C183C", Length = "0x270")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddPermissionTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_masterMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			private void UpdateSliderColorAndShowMultiplierMouseOver(UIElement affectedElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D59")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1AAC", Offset = "0x8C1AAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1AB4", Offset = "0x8C1AB4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(BinaryWriter writer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1AD0", Offset = "0x8C1AD0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1B0C", Offset = "0x8C1B0C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008699")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private float <StrengthMultiplierToGiveNPCs>k__BackingField;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A45")]
		public class ModifyWindDirectionAndStrength : CreativePowers.ASharedSliderPower
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004D5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1B20", Offset = "0x8C1B20", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public ModifyWindDirectionAndStrength()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1BB0", Offset = "0x8C1BB0", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal override void UpdateInfoFromSliderValueCache()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1C38", Offset = "0x8C1C38", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal override float GetSliderValueInner()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D60")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1CDC", Offset = "0x8C1CDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D61")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1CE4", Offset = "0x8C1CE4", Length = "0x5CC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "CreateSlider", MemberParameters = new object[]
			{
				typeof(Func<float>),
				typeof(Action<float>),
				typeof(Action)
			}, ReturnType = typeof(UIVerticalSlider))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(LocalizedText),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
			public override UIElement ProvideSlider()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D62")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C22B0", Offset = "0x8C22B0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D63")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C22EC", Offset = "0x8C22EC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D64")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C231C", Offset = "0x8C231C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D65")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C234C", Offset = "0x8C234C", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D66")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C2410", Offset = "0x8C2410", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D67")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C24D4", Offset = "0x8C24D4", Length = "0x1DC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddPermissionTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A46")]
		public class ModifyRainPower : CreativePowers.ASharedSliderPower
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004D68")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C26B0", Offset = "0x8C26B0", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public ModifyRainPower()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D69")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C2740", Offset = "0x8C2740", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "StopRain", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "StartRain", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal override void UpdateInfoFromSliderValueCache()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C27E4", Offset = "0x8C27E4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal override float GetSliderValueInner()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C283C", Offset = "0x8C283C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C2844", Offset = "0x8C2844", Length = "0x5CC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "CreateSlider", MemberParameters = new object[]
			{
				typeof(Func<float>),
				typeof(Action<float>),
				typeof(Action)
			}, ReturnType = typeof(UIVerticalSlider))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(LocalizedText),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
			public override UIElement ProvideSlider()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C2E10", Offset = "0x8C2E10", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C2E4C", Offset = "0x8C2E4C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C2E7C", Offset = "0x8C2E7C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D70")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C2EAC", Offset = "0x8C2EAC", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D71")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C2F70", Offset = "0x8C2F70", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D72")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3034", Offset = "0x8C3034", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddPermissionTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A47")]
		public class FreezeTime : CreativePowers.ASharedTogglePower, IPersistentPerWorldContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004D73")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C313C", Offset = "0x8C313C", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "GetIconImage", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(UIImageFramed))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal override void CustomizeButton(UIElement button)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D74")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C31D4", Offset = "0x8C31D4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal override string GetButtonTextKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D75")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3214", Offset = "0x8C3214", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D76")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C321C", Offset = "0x8C321C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(BinaryWriter writer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D77")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3234", Offset = "0x8C3234", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D78")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3260", Offset = "0x8C3260", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D79")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3270", Offset = "0x8C3270", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FreezeTime()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A48")]
		public class FreezeWindDirectionAndStrength : CreativePowers.ASharedTogglePower, IPersistentPerWorldContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004D7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3278", Offset = "0x8C3278", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "GetIconImage", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(UIImageFramed))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal override void CustomizeButton(UIElement button)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3310", Offset = "0x8C3310", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal override string GetButtonTextKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3350", Offset = "0x8C3350", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D7D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3358", Offset = "0x8C3358", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(BinaryWriter writer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3370", Offset = "0x8C3370", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C339C", Offset = "0x8C339C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D80")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C33AC", Offset = "0x8C33AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FreezeWindDirectionAndStrength()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A49")]
		public class FreezeRainPower : CreativePowers.ASharedTogglePower, IPersistentPerWorldContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004D81")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C33B4", Offset = "0x8C33B4", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "GetIconImage", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(UIImageFramed))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal override void CustomizeButton(UIElement button)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D82")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C344C", Offset = "0x8C344C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal override string GetButtonTextKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D83")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C348C", Offset = "0x8C348C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D84")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3494", Offset = "0x8C3494", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(BinaryWriter writer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D85")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C34AC", Offset = "0x8C34AC", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D86")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C34D8", Offset = "0x8C34D8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D87")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C34E8", Offset = "0x8C34E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FreezeRainPower()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A4A")]
		public class StopBiomeSpreadPower : CreativePowers.ASharedTogglePower, IPersistentPerWorldContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004D88")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C34F0", Offset = "0x8C34F0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "GetIconImage", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(UIImageFramed))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal override void CustomizeButton(UIElement button)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D89")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3588", Offset = "0x8C3588", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal override string GetButtonTextKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C35C8", Offset = "0x8C35C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D8B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C35D0", Offset = "0x8C35D0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(BinaryWriter writer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D8C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C35E8", Offset = "0x8C35E8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3614", Offset = "0x8C3614", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3624", Offset = "0x8C3624", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public StopBiomeSpreadPower()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A4B")]
		public class SpawnRateSliderPerPlayerPower : CreativePowers.APerPlayerSliderPower, IPersistentPerPlayerContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000892")]
			public float StrengthMultiplierToGiveNPCs
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D8F")]
				[global::Cpp2ILInjected.Address(RVA = "0x8C362C", Offset = "0x8C362C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004D90")]
				[global::Cpp2ILInjected.Address(RVA = "0x8C3634", Offset = "0x8C3634", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D91")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C363C", Offset = "0x8C363C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public SpawnRateSliderPerPlayerPower()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D92")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C36D0", Offset = "0x8C36D0", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "GetStringValue", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SlimeRainSpawns", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SpawnNPC", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "UpdateSliderAndShowMultiplierMouseOver", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "IndexInRange", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(float[]),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool GetShouldDisableSpawnsFor(int playerIndex)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D93")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C37B0", Offset = "0x8C37B0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal override void UpdateInfoFromSliderValueCache()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D94")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C37B4", Offset = "0x8C37B4", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Remap", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override float RemapSliderValueToPowerValue(float sliderValue)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D95")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3854", Offset = "0x8C3854", Length = "0x590")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "CreateSlider", MemberParameters = new object[]
			{
				typeof(Func<float>),
				typeof(Action<float>),
				typeof(Action)
			}, ReturnType = typeof(UIVerticalSlider))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
			public override UIElement ProvideSlider()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D96")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3DE4", Offset = "0x8C3DE4", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D97")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3EA8", Offset = "0x8C3EA8", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D98")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3F6C", Offset = "0x8C3F6C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "SetValueKeyboard", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D99")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3FA8", Offset = "0x8C3FA8", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "SetValueKeyboard", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3FD8", Offset = "0x8C3FD8", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "SetValueKeyboard", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C4008", Offset = "0x8C4008", Length = "0x1A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "GetSliderValue", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "GetShouldDisableSpawnsFor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddPermissionTextIfNeeded", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(byte),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C41AC", Offset = "0x8C41AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C41B4", Offset = "0x8C41B4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(Player player, BinaryWriter writer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D9E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C41CC", Offset = "0x8C41CC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void ResetDataForNewPlayer(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004D9F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C41DC", Offset = "0x8C41DC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004DA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C420C", Offset = "0x8C420C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "PushChangeAndSetSlider", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			public void ApplyLoadedDataToOutOfPlayerFields(Player player)
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400869A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private float <StrengthMultiplierToGiveNPCs>k__BackingField;
		}
	}
}
