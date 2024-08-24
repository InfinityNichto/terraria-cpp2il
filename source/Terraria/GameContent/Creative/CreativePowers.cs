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
	// Token: 0x0200068C RID: 1676
	[global::Cpp2ILInjected.Token(Token = "0x2000A36")]
	public class CreativePowers
	{
		// Token: 0x060041B7 RID: 16823 RVA: 0x0002DBDB File Offset: 0x0002BDDB
		[global::Cpp2ILInjected.Token(Token = "0x6004CA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8BC434", Offset = "0x8BC434", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CreativePowers()
		{
			throw null;
		}

		// Token: 0x02000A88 RID: 2696
		[global::Cpp2ILInjected.Token(Token = "0x2000A37")]
		public abstract class APerPlayerTogglePower : ICreativePower, IOnPlayerJoining
		{
			// Token: 0x170008E7 RID: 2279
			// (get) Token: 0x0600511E RID: 20766 RVA: 0x000304EE File Offset: 0x0002E6EE
			// (set) Token: 0x0600511F RID: 20767 RVA: 0x000304F1 File Offset: 0x0002E6F1
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

			// Token: 0x170008E8 RID: 2280
			// (get) Token: 0x06005120 RID: 20768 RVA: 0x000304F4 File Offset: 0x0002E6F4
			// (set) Token: 0x06005121 RID: 20769 RVA: 0x000304F7 File Offset: 0x0002E6F7
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

			// Token: 0x170008E9 RID: 2281
			// (get) Token: 0x06005122 RID: 20770 RVA: 0x000304FA File Offset: 0x0002E6FA
			// (set) Token: 0x06005123 RID: 20771 RVA: 0x000304FD File Offset: 0x0002E6FD
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

			// Token: 0x170008EA RID: 2282
			// (get) Token: 0x06005124 RID: 20772 RVA: 0x00030500 File Offset: 0x0002E700
			// (set) Token: 0x06005125 RID: 20773 RVA: 0x00030503 File Offset: 0x0002E703
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

			// Token: 0x06005126 RID: 20774 RVA: 0x00030506 File Offset: 0x0002E706
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

			// Token: 0x06005127 RID: 20775 RVA: 0x00030509 File Offset: 0x0002E709
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

			// Token: 0x06005128 RID: 20776 RVA: 0x0003050C File Offset: 0x0002E70C
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

			// Token: 0x06005129 RID: 20777 RVA: 0x0003050F File Offset: 0x0002E70F
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

			// Token: 0x0600512A RID: 20778 RVA: 0x00030512 File Offset: 0x0002E712
			[global::Cpp2ILInjected.Token(Token = "0x6004CB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC964", Offset = "0x8BC964", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void DebugCall()
			{
				throw null;
			}

			// Token: 0x0600512B RID: 20779 RVA: 0x00030515 File Offset: 0x0002E715
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

			// Token: 0x0600512C RID: 20780 RVA: 0x00030518 File Offset: 0x0002E718
			[global::Cpp2ILInjected.Token(Token = "0x6004CB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BCACC", Offset = "0x8BCACC", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x0600512D RID: 20781 RVA: 0x0003051B File Offset: 0x0002E71B
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

			// Token: 0x0600512E RID: 20782 RVA: 0x0003051E File Offset: 0x0002E71E
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

			// Token: 0x0600512F RID: 20783 RVA: 0x00030521 File Offset: 0x0002E721
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

			// Token: 0x06005130 RID: 20784 RVA: 0x00030524 File Offset: 0x0002E724
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

			// Token: 0x06005131 RID: 20785
			[global::Cpp2ILInjected.Token(Token = "0x6004CBD")]
			public abstract bool GetIsUnlocked();

			// Token: 0x06005132 RID: 20786 RVA: 0x00030527 File Offset: 0x0002E727
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

			// Token: 0x04008EA9 RID: 36521
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400866A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ushort <PowerId>k__BackingField;

			// Token: 0x04008EAA RID: 36522
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400866B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x04008EAB RID: 36523
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400866C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x04008EAC RID: 36524
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400866D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x04008EAD RID: 36525
			[global::Cpp2ILInjected.Token(Token = "0x400866E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal string _powerNameKey;

			// Token: 0x04008EAE RID: 36526
			[global::Cpp2ILInjected.Token(Token = "0x400866F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal Point _iconLocation;

			// Token: 0x04008EAF RID: 36527
			[global::Cpp2ILInjected.Token(Token = "0x4008670")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal bool _defaultToggleState;

			// Token: 0x04008EB0 RID: 36528
			[global::Cpp2ILInjected.Token(Token = "0x4008671")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private bool[] _perPlayerIsEnabled;

			// Token: 0x02000BD1 RID: 3025
			[global::Cpp2ILInjected.Token(Token = "0x2000A38")]
			private enum SubMessageType : byte
			{
				// Token: 0x0400915D RID: 37213
				[global::Cpp2ILInjected.Token(Token = "0x4008673")]
				SyncEveryone,
				// Token: 0x0400915E RID: 37214
				[global::Cpp2ILInjected.Token(Token = "0x4008674")]
				SyncOnePlayer
			}
		}

		// Token: 0x02000A89 RID: 2697
		[global::Cpp2ILInjected.Token(Token = "0x2000A39")]
		public abstract class APerPlayerSliderPower : ICreativePower, IOnPlayerJoining, IProvideSliderElement, IPowerSubcategoryElement
		{
			// Token: 0x170008EB RID: 2283
			// (get) Token: 0x06005133 RID: 20787 RVA: 0x0003052A File Offset: 0x0002E72A
			// (set) Token: 0x06005134 RID: 20788 RVA: 0x0003052D File Offset: 0x0002E72D
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

			// Token: 0x170008EC RID: 2284
			// (get) Token: 0x06005135 RID: 20789 RVA: 0x00030530 File Offset: 0x0002E730
			// (set) Token: 0x06005136 RID: 20790 RVA: 0x00030533 File Offset: 0x0002E733
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

			// Token: 0x170008ED RID: 2285
			// (get) Token: 0x06005137 RID: 20791 RVA: 0x00030536 File Offset: 0x0002E736
			// (set) Token: 0x06005138 RID: 20792 RVA: 0x00030539 File Offset: 0x0002E739
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

			// Token: 0x170008EE RID: 2286
			// (get) Token: 0x06005139 RID: 20793 RVA: 0x0003053C File Offset: 0x0002E73C
			// (set) Token: 0x0600513A RID: 20794 RVA: 0x0003053F File Offset: 0x0002E73F
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

			// Token: 0x0600513B RID: 20795 RVA: 0x00030542 File Offset: 0x0002E742
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

			// Token: 0x0600513C RID: 20796
			[global::Cpp2ILInjected.Token(Token = "0x6004CC8")]
			public abstract float RemapSliderValueToPowerValue(float sliderValue);

			// Token: 0x0600513D RID: 20797 RVA: 0x00030545 File Offset: 0x0002E745
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

			// Token: 0x0600513E RID: 20798
			[global::Cpp2ILInjected.Token(Token = "0x6004CCA")]
			internal abstract void UpdateInfoFromSliderValueCache();

			// Token: 0x0600513F RID: 20799 RVA: 0x00030548 File Offset: 0x0002E748
			[global::Cpp2ILInjected.Token(Token = "0x6004CCB")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD43C", Offset = "0x8BD43C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
				throw null;
			}

			// Token: 0x06005140 RID: 20800 RVA: 0x0003054B File Offset: 0x0002E74B
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

			// Token: 0x06005141 RID: 20801
			[global::Cpp2ILInjected.Token(Token = "0x6004CCD")]
			public abstract UIElement ProvideSlider();

			// Token: 0x06005142 RID: 20802 RVA: 0x0003054E File Offset: 0x0002E74E
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

			// Token: 0x06005143 RID: 20803 RVA: 0x00030551 File Offset: 0x0002E751
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

			// Token: 0x06005144 RID: 20804 RVA: 0x00030554 File Offset: 0x0002E754
			[global::Cpp2ILInjected.Token(Token = "0x6004CD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BD6D4", Offset = "0x8BD6D4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "GetSliderValue", ReturnType = typeof(float))]
			internal void SetValueGamepad()
			{
				throw null;
			}

			// Token: 0x06005145 RID: 20805 RVA: 0x00030557 File Offset: 0x0002E757
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

			// Token: 0x06005146 RID: 20806 RVA: 0x0003055A File Offset: 0x0002E75A
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

			// Token: 0x06005147 RID: 20807 RVA: 0x0003055D File Offset: 0x0002E75D
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

			// Token: 0x06005148 RID: 20808 RVA: 0x00030560 File Offset: 0x0002E760
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

			// Token: 0x06005149 RID: 20809 RVA: 0x00030563 File Offset: 0x0002E763
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

			// Token: 0x0600514A RID: 20810 RVA: 0x00030566 File Offset: 0x0002E766
			[global::Cpp2ILInjected.Token(Token = "0x6004CD6")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BDCE8", Offset = "0x8BDCE8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public virtual void Reset()
			{
				throw null;
			}

			// Token: 0x0600514B RID: 20811 RVA: 0x00030569 File Offset: 0x0002E769
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

			// Token: 0x0600514C RID: 20812 RVA: 0x0003056C File Offset: 0x0002E76C
			[global::Cpp2ILInjected.Token(Token = "0x6004CD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BDDC8", Offset = "0x8BDDC8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void OnPlayerJoining(int playerIndex)
			{
				throw null;
			}

			// Token: 0x0600514D RID: 20813
			[global::Cpp2ILInjected.Token(Token = "0x6004CD9")]
			public abstract bool GetIsUnlocked();

			// Token: 0x0600514E RID: 20814 RVA: 0x0003056F File Offset: 0x0002E76F
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

			// Token: 0x04008EB1 RID: 36529
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008675")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ushort <PowerId>k__BackingField;

			// Token: 0x04008EB2 RID: 36530
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008676")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x04008EB3 RID: 36531
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008677")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x04008EB4 RID: 36532
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008678")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x04008EB5 RID: 36533
			[global::Cpp2ILInjected.Token(Token = "0x4008679")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal Point _iconLocation;

			// Token: 0x04008EB6 RID: 36534
			[global::Cpp2ILInjected.Token(Token = "0x400867A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal float _sliderCurrentValueCache;

			// Token: 0x04008EB7 RID: 36535
			[global::Cpp2ILInjected.Token(Token = "0x400867B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal string _powerNameKey;

			// Token: 0x04008EB8 RID: 36536
			[global::Cpp2ILInjected.Token(Token = "0x400867C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			internal float[] _cachePerPlayer;

			// Token: 0x04008EB9 RID: 36537
			[global::Cpp2ILInjected.Token(Token = "0x400867D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			internal float _sliderDefaultValue;

			// Token: 0x04008EBA RID: 36538
			[global::Cpp2ILInjected.Token(Token = "0x400867E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			private float _currentTargetValue;

			// Token: 0x04008EBB RID: 36539
			[global::Cpp2ILInjected.Token(Token = "0x400867F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private bool _needsToCommitChange;

			// Token: 0x04008EBC RID: 36540
			[global::Cpp2ILInjected.Token(Token = "0x4008680")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private DateTime _nextTimeWeCanPush;
		}

		// Token: 0x02000A8A RID: 2698
		[global::Cpp2ILInjected.Token(Token = "0x2000A3A")]
		public abstract class ASharedButtonPower : ICreativePower
		{
			// Token: 0x170008EF RID: 2287
			// (get) Token: 0x0600514F RID: 20815 RVA: 0x00030572 File Offset: 0x0002E772
			// (set) Token: 0x06005150 RID: 20816 RVA: 0x00030575 File Offset: 0x0002E775
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

			// Token: 0x170008F0 RID: 2288
			// (get) Token: 0x06005151 RID: 20817 RVA: 0x00030578 File Offset: 0x0002E778
			// (set) Token: 0x06005152 RID: 20818 RVA: 0x0003057B File Offset: 0x0002E77B
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

			// Token: 0x170008F1 RID: 2289
			// (get) Token: 0x06005153 RID: 20819 RVA: 0x0003057E File Offset: 0x0002E77E
			// (set) Token: 0x06005154 RID: 20820 RVA: 0x00030581 File Offset: 0x0002E781
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

			// Token: 0x170008F2 RID: 2290
			// (get) Token: 0x06005155 RID: 20821 RVA: 0x00030584 File Offset: 0x0002E784
			// (set) Token: 0x06005156 RID: 20822 RVA: 0x00030587 File Offset: 0x0002E787
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

			// Token: 0x06005157 RID: 20823 RVA: 0x0003058A File Offset: 0x0002E78A
			[global::Cpp2ILInjected.Token(Token = "0x6004CE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BDEA8", Offset = "0x8BDEA8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public ASharedButtonPower()
			{
				throw null;
			}

			// Token: 0x06005158 RID: 20824 RVA: 0x0003058D File Offset: 0x0002E78D
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

			// Token: 0x06005159 RID: 20825 RVA: 0x00030590 File Offset: 0x0002E790
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

			// Token: 0x0600515A RID: 20826
			[global::Cpp2ILInjected.Token(Token = "0x6004CE6")]
			internal abstract void UsePower();

			// Token: 0x0600515B RID: 20827
			[global::Cpp2ILInjected.Token(Token = "0x6004CE7")]
			internal abstract void OnCreation();

			// Token: 0x0600515C RID: 20828 RVA: 0x00030593 File Offset: 0x0002E793
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

			// Token: 0x0600515D RID: 20829 RVA: 0x00030596 File Offset: 0x0002E796
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

			// Token: 0x0600515E RID: 20830 RVA: 0x00030599 File Offset: 0x0002E799
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

			// Token: 0x0600515F RID: 20831
			[global::Cpp2ILInjected.Token(Token = "0x6004CEB")]
			public abstract bool GetIsUnlocked();

			// Token: 0x04008EBD RID: 36541
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008681")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ushort <PowerId>k__BackingField;

			// Token: 0x04008EBE RID: 36542
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008682")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x04008EBF RID: 36543
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008683")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x04008EC0 RID: 36544
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008684")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x04008EC1 RID: 36545
			[global::Cpp2ILInjected.Token(Token = "0x4008685")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal Point _iconLocation;

			// Token: 0x04008EC2 RID: 36546
			[global::Cpp2ILInjected.Token(Token = "0x4008686")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal string _powerNameKey;

			// Token: 0x04008EC3 RID: 36547
			[global::Cpp2ILInjected.Token(Token = "0x4008687")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal string _descriptionKey;
		}

		// Token: 0x02000A8B RID: 2699
		[global::Cpp2ILInjected.Token(Token = "0x2000A3B")]
		public abstract class ASharedTogglePower : ICreativePower, IOnPlayerJoining
		{
			// Token: 0x170008F3 RID: 2291
			// (get) Token: 0x06005160 RID: 20832 RVA: 0x0003059C File Offset: 0x0002E79C
			// (set) Token: 0x06005161 RID: 20833 RVA: 0x0003059F File Offset: 0x0002E79F
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

			// Token: 0x170008F4 RID: 2292
			// (get) Token: 0x06005162 RID: 20834 RVA: 0x000305A2 File Offset: 0x0002E7A2
			// (set) Token: 0x06005163 RID: 20835 RVA: 0x000305A5 File Offset: 0x0002E7A5
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

			// Token: 0x170008F5 RID: 2293
			// (get) Token: 0x06005164 RID: 20836 RVA: 0x000305A8 File Offset: 0x0002E7A8
			// (set) Token: 0x06005165 RID: 20837 RVA: 0x000305AB File Offset: 0x0002E7AB
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

			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x06005166 RID: 20838 RVA: 0x000305AE File Offset: 0x0002E7AE
			// (set) Token: 0x06005167 RID: 20839 RVA: 0x000305B1 File Offset: 0x0002E7B1
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

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x06005168 RID: 20840 RVA: 0x000305B4 File Offset: 0x0002E7B4
			// (set) Token: 0x06005169 RID: 20841 RVA: 0x000305B7 File Offset: 0x0002E7B7
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

			// Token: 0x0600516A RID: 20842 RVA: 0x000305BA File Offset: 0x0002E7BA
			[global::Cpp2ILInjected.Token(Token = "0x6004CF6")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BE440", Offset = "0x8BE440", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetPowerInfo(bool enabled)
			{
				throw null;
			}

			// Token: 0x0600516B RID: 20843 RVA: 0x000305BD File Offset: 0x0002E7BD
			[global::Cpp2ILInjected.Token(Token = "0x6004CF7")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BE44C", Offset = "0x8BE44C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x0600516C RID: 20844 RVA: 0x000305C0 File Offset: 0x0002E7C0
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

			// Token: 0x0600516D RID: 20845 RVA: 0x000305C3 File Offset: 0x0002E7C3
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

			// Token: 0x0600516E RID: 20846 RVA: 0x000305C6 File Offset: 0x0002E7C6
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

			// Token: 0x0600516F RID: 20847 RVA: 0x000305C9 File Offset: 0x0002E7C9
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

			// Token: 0x06005170 RID: 20848 RVA: 0x000305CC File Offset: 0x0002E7CC
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

			// Token: 0x06005171 RID: 20849 RVA: 0x000305CF File Offset: 0x0002E7CF
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

			// Token: 0x06005172 RID: 20850
			[global::Cpp2ILInjected.Token(Token = "0x6004CFE")]
			internal abstract void CustomizeButton(UIElement button);

			// Token: 0x06005173 RID: 20851
			[global::Cpp2ILInjected.Token(Token = "0x6004CFF")]
			internal abstract string GetButtonTextKey();

			// Token: 0x06005174 RID: 20852
			[global::Cpp2ILInjected.Token(Token = "0x6004D00")]
			public abstract bool GetIsUnlocked();

			// Token: 0x06005175 RID: 20853 RVA: 0x000305D2 File Offset: 0x0002E7D2
			[global::Cpp2ILInjected.Token(Token = "0x6004D01")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BEC50", Offset = "0x8BEC50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected ASharedTogglePower()
			{
				throw null;
			}

			// Token: 0x04008EC4 RID: 36548
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008688")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ushort <PowerId>k__BackingField;

			// Token: 0x04008EC5 RID: 36549
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008689")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x04008EC6 RID: 36550
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400868A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x04008EC7 RID: 36551
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400868B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x04008EC8 RID: 36552
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400868C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private bool <Enabled>k__BackingField;
		}

		// Token: 0x02000A8C RID: 2700
		[global::Cpp2ILInjected.Token(Token = "0x2000A3C")]
		public abstract class ASharedSliderPower : ICreativePower, IOnPlayerJoining, IProvideSliderElement, IPowerSubcategoryElement
		{
			// Token: 0x170008F8 RID: 2296
			// (get) Token: 0x06005176 RID: 20854 RVA: 0x000305D5 File Offset: 0x0002E7D5
			// (set) Token: 0x06005177 RID: 20855 RVA: 0x000305D8 File Offset: 0x0002E7D8
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

			// Token: 0x170008F9 RID: 2297
			// (get) Token: 0x06005178 RID: 20856 RVA: 0x000305DB File Offset: 0x0002E7DB
			// (set) Token: 0x06005179 RID: 20857 RVA: 0x000305DE File Offset: 0x0002E7DE
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

			// Token: 0x170008FA RID: 2298
			// (get) Token: 0x0600517A RID: 20858 RVA: 0x000305E1 File Offset: 0x0002E7E1
			// (set) Token: 0x0600517B RID: 20859 RVA: 0x000305E4 File Offset: 0x0002E7E4
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

			// Token: 0x170008FB RID: 2299
			// (get) Token: 0x0600517C RID: 20860 RVA: 0x000305E7 File Offset: 0x0002E7E7
			// (set) Token: 0x0600517D RID: 20861 RVA: 0x000305EA File Offset: 0x0002E7EA
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

			// Token: 0x0600517E RID: 20862 RVA: 0x000305ED File Offset: 0x0002E7ED
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

			// Token: 0x0600517F RID: 20863
			[global::Cpp2ILInjected.Token(Token = "0x6004D0B")]
			internal abstract void UpdateInfoFromSliderValueCache();

			// Token: 0x06005180 RID: 20864 RVA: 0x000305F0 File Offset: 0x0002E7F0
			[global::Cpp2ILInjected.Token(Token = "0x6004D0C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BEE34", Offset = "0x8BEE34", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
				throw null;
			}

			// Token: 0x06005181 RID: 20865 RVA: 0x000305F3 File Offset: 0x0002E7F3
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

			// Token: 0x06005182 RID: 20866
			[global::Cpp2ILInjected.Token(Token = "0x6004D0E")]
			public abstract UIElement ProvideSlider();

			// Token: 0x06005183 RID: 20867 RVA: 0x000305F6 File Offset: 0x0002E7F6
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

			// Token: 0x06005184 RID: 20868 RVA: 0x000305F9 File Offset: 0x0002E7F9
			[global::Cpp2ILInjected.Token(Token = "0x6004D10")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BEFC0", Offset = "0x8BEFC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal virtual float GetSliderValueInner()
			{
				throw null;
			}

			// Token: 0x06005185 RID: 20869 RVA: 0x000305FC File Offset: 0x0002E7FC
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

			// Token: 0x06005186 RID: 20870 RVA: 0x000305FF File Offset: 0x0002E7FF
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

			// Token: 0x06005187 RID: 20871 RVA: 0x00030602 File Offset: 0x0002E802
			[global::Cpp2ILInjected.Token(Token = "0x6004D13")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF0D0", Offset = "0x8BF0D0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "GetSliderValue", ReturnType = typeof(float))]
			internal void SetValueGamepad()
			{
				throw null;
			}

			// Token: 0x06005188 RID: 20872 RVA: 0x00030605 File Offset: 0x0002E805
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

			// Token: 0x06005189 RID: 20873 RVA: 0x00030608 File Offset: 0x0002E808
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

			// Token: 0x0600518A RID: 20874 RVA: 0x0003060B File Offset: 0x0002E80B
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

			// Token: 0x0600518B RID: 20875 RVA: 0x0003060E File Offset: 0x0002E80E
			[global::Cpp2ILInjected.Token(Token = "0x6004D17")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF56C", Offset = "0x8BF56C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public virtual void Reset()
			{
				throw null;
			}

			// Token: 0x0600518C RID: 20876 RVA: 0x00030611 File Offset: 0x0002E811
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

			// Token: 0x0600518D RID: 20877
			[global::Cpp2ILInjected.Token(Token = "0x6004D19")]
			public abstract bool GetIsUnlocked();

			// Token: 0x0600518E RID: 20878 RVA: 0x00030614 File Offset: 0x0002E814
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

			// Token: 0x04008EC9 RID: 36553
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400868D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ushort <PowerId>k__BackingField;

			// Token: 0x04008ECA RID: 36554
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400868E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x04008ECB RID: 36555
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400868F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x04008ECC RID: 36556
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008690")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x04008ECD RID: 36557
			[global::Cpp2ILInjected.Token(Token = "0x4008691")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal Point _iconLocation;

			// Token: 0x04008ECE RID: 36558
			[global::Cpp2ILInjected.Token(Token = "0x4008692")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal float _sliderCurrentValueCache;

			// Token: 0x04008ECF RID: 36559
			[global::Cpp2ILInjected.Token(Token = "0x4008693")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal string _powerNameKey;

			// Token: 0x04008ED0 RID: 36560
			[global::Cpp2ILInjected.Token(Token = "0x4008694")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			internal bool _syncToJoiningPlayers;

			// Token: 0x04008ED1 RID: 36561
			[global::Cpp2ILInjected.Token(Token = "0x4008695")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
			internal float _currentTargetValue;

			// Token: 0x04008ED2 RID: 36562
			[global::Cpp2ILInjected.Token(Token = "0x4008696")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private bool _needsToCommitChange;

			// Token: 0x04008ED3 RID: 36563
			[global::Cpp2ILInjected.Token(Token = "0x4008697")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private DateTime _nextTimeWeCanPush;
		}

		// Token: 0x02000A8D RID: 2701
		[global::Cpp2ILInjected.Token(Token = "0x2000A3D")]
		public class GodmodePower : CreativePowers.APerPlayerTogglePower, IPersistentPerPlayerContent
		{
			// Token: 0x0600518F RID: 20879 RVA: 0x00030617 File Offset: 0x0002E817
			[global::Cpp2ILInjected.Token(Token = "0x6004D1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF6C8", Offset = "0x8BF6C8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public GodmodePower()
			{
				throw null;
			}

			// Token: 0x06005190 RID: 20880 RVA: 0x0003061A File Offset: 0x0002E81A
			[global::Cpp2ILInjected.Token(Token = "0x6004D1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF754", Offset = "0x8BF754", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x06005191 RID: 20881 RVA: 0x0003061D File Offset: 0x0002E81D
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

			// Token: 0x06005192 RID: 20882 RVA: 0x00030620 File Offset: 0x0002E820
			[global::Cpp2ILInjected.Token(Token = "0x6004D1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF7DC", Offset = "0x8BF7DC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void ResetDataForNewPlayer(Player player)
			{
				throw null;
			}

			// Token: 0x06005193 RID: 20883 RVA: 0x00030623 File Offset: 0x0002E823
			[global::Cpp2ILInjected.Token(Token = "0x6004D1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF7EC", Offset = "0x8BF7EC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x06005194 RID: 20884 RVA: 0x00030626 File Offset: 0x0002E826
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

		// Token: 0x02000A8E RID: 2702
		[global::Cpp2ILInjected.Token(Token = "0x2000A3E")]
		public class FarPlacementRangePower : CreativePowers.APerPlayerTogglePower, IPersistentPerPlayerContent
		{
			// Token: 0x06005195 RID: 20885 RVA: 0x00030629 File Offset: 0x0002E829
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

			// Token: 0x06005196 RID: 20886 RVA: 0x0003062C File Offset: 0x0002E82C
			[global::Cpp2ILInjected.Token(Token = "0x6004D22")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF928", Offset = "0x8BF928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x06005197 RID: 20887 RVA: 0x0003062F File Offset: 0x0002E82F
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

			// Token: 0x06005198 RID: 20888 RVA: 0x00030632 File Offset: 0x0002E832
			[global::Cpp2ILInjected.Token(Token = "0x6004D24")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF9B0", Offset = "0x8BF9B0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void ResetDataForNewPlayer(Player player)
			{
				throw null;
			}

			// Token: 0x06005199 RID: 20889 RVA: 0x00030635 File Offset: 0x0002E835
			[global::Cpp2ILInjected.Token(Token = "0x6004D25")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BF9C0", Offset = "0x8BF9C0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x0600519A RID: 20890 RVA: 0x00030638 File Offset: 0x0002E838
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

		// Token: 0x02000A8F RID: 2703
		[global::Cpp2ILInjected.Token(Token = "0x2000A3F")]
		public class StartDayImmediately : CreativePowers.ASharedButtonPower
		{
			// Token: 0x0600519B RID: 20891 RVA: 0x0003063B File Offset: 0x0002E83B
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

			// Token: 0x0600519C RID: 20892 RVA: 0x0003063E File Offset: 0x0002E83E
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

			// Token: 0x0600519D RID: 20893 RVA: 0x00030641 File Offset: 0x0002E841
			[global::Cpp2ILInjected.Token(Token = "0x6004D29")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFB5C", Offset = "0x8BFB5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x0600519E RID: 20894 RVA: 0x00030644 File Offset: 0x0002E844
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

		// Token: 0x02000A90 RID: 2704
		[global::Cpp2ILInjected.Token(Token = "0x2000A40")]
		public class StartNightImmediately : CreativePowers.ASharedButtonPower
		{
			// Token: 0x0600519F RID: 20895 RVA: 0x00030647 File Offset: 0x0002E847
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

			// Token: 0x060051A0 RID: 20896 RVA: 0x0003064A File Offset: 0x0002E84A
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

			// Token: 0x060051A1 RID: 20897 RVA: 0x0003064D File Offset: 0x0002E84D
			[global::Cpp2ILInjected.Token(Token = "0x6004D2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFCB4", Offset = "0x8BFCB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x060051A2 RID: 20898 RVA: 0x00030650 File Offset: 0x0002E850
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

		// Token: 0x02000A91 RID: 2705
		[global::Cpp2ILInjected.Token(Token = "0x2000A41")]
		public class StartNoonImmediately : CreativePowers.ASharedButtonPower
		{
			// Token: 0x060051A3 RID: 20899 RVA: 0x00030653 File Offset: 0x0002E853
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

			// Token: 0x060051A4 RID: 20900 RVA: 0x00030656 File Offset: 0x0002E856
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

			// Token: 0x060051A5 RID: 20901 RVA: 0x00030659 File Offset: 0x0002E859
			[global::Cpp2ILInjected.Token(Token = "0x6004D31")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFE0C", Offset = "0x8BFE0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x060051A6 RID: 20902 RVA: 0x0003065C File Offset: 0x0002E85C
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

		// Token: 0x02000A92 RID: 2706
		[global::Cpp2ILInjected.Token(Token = "0x2000A42")]
		public class StartMidnightImmediately : CreativePowers.ASharedButtonPower
		{
			// Token: 0x060051A7 RID: 20903 RVA: 0x0003065F File Offset: 0x0002E85F
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

			// Token: 0x060051A8 RID: 20904 RVA: 0x00030662 File Offset: 0x0002E862
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

			// Token: 0x060051A9 RID: 20905 RVA: 0x00030665 File Offset: 0x0002E865
			[global::Cpp2ILInjected.Token(Token = "0x6004D35")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFF64", Offset = "0x8BFF64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x060051AA RID: 20906 RVA: 0x00030668 File Offset: 0x0002E868
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

		// Token: 0x02000A93 RID: 2707
		[global::Cpp2ILInjected.Token(Token = "0x2000A43")]
		public class ModifyTimeRate : CreativePowers.ASharedSliderPower, IPersistentPerWorldContent
		{
			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x060051AB RID: 20907 RVA: 0x0003066B File Offset: 0x0002E86B
			// (set) Token: 0x060051AC RID: 20908 RVA: 0x0003066E File Offset: 0x0002E86E
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

			// Token: 0x060051AD RID: 20909 RVA: 0x00030671 File Offset: 0x0002E871
			[global::Cpp2ILInjected.Token(Token = "0x6004D39")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BFFA4", Offset = "0x8BFFA4", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public ModifyTimeRate()
			{
				throw null;
			}

			// Token: 0x060051AE RID: 20910 RVA: 0x00030674 File Offset: 0x0002E874
			[global::Cpp2ILInjected.Token(Token = "0x6004D3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0030", Offset = "0x8C0030", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Reset()
			{
				throw null;
			}

			// Token: 0x060051AF RID: 20911 RVA: 0x00030677 File Offset: 0x0002E877
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

			// Token: 0x060051B0 RID: 20912 RVA: 0x0003067A File Offset: 0x0002E87A
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

			// Token: 0x060051B1 RID: 20913 RVA: 0x0003067D File Offset: 0x0002E87D
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

			// Token: 0x060051B2 RID: 20914 RVA: 0x00030680 File Offset: 0x0002E880
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

			// Token: 0x060051B3 RID: 20915 RVA: 0x00030683 File Offset: 0x0002E883
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

			// Token: 0x060051B4 RID: 20916 RVA: 0x00030686 File Offset: 0x0002E886
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

			// Token: 0x060051B5 RID: 20917 RVA: 0x00030689 File Offset: 0x0002E889
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

			// Token: 0x060051B6 RID: 20918 RVA: 0x0003068C File Offset: 0x0002E88C
			[global::Cpp2ILInjected.Token(Token = "0x6004D42")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0928", Offset = "0x8C0928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x060051B7 RID: 20919 RVA: 0x0003068F File Offset: 0x0002E88F
			[global::Cpp2ILInjected.Token(Token = "0x6004D43")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0930", Offset = "0x8C0930", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(BinaryWriter writer)
			{
				throw null;
			}

			// Token: 0x060051B8 RID: 20920 RVA: 0x00030692 File Offset: 0x0002E892
			[global::Cpp2ILInjected.Token(Token = "0x6004D44")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C094C", Offset = "0x8C094C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x060051B9 RID: 20921 RVA: 0x00030695 File Offset: 0x0002E895
			[global::Cpp2ILInjected.Token(Token = "0x6004D45")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0988", Offset = "0x8C0988", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x060051BA RID: 20922 RVA: 0x00030698 File Offset: 0x0002E898
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

			// Token: 0x04008ED4 RID: 36564
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008698")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private int <TargetTimeRate>k__BackingField;
		}

		// Token: 0x02000A94 RID: 2708
		[global::Cpp2ILInjected.Token(Token = "0x2000A44")]
		public class DifficultySliderPower : CreativePowers.ASharedSliderPower, IPersistentPerWorldContent
		{
			// Token: 0x170008FD RID: 2301
			// (get) Token: 0x060051BB RID: 20923 RVA: 0x0003069B File Offset: 0x0002E89B
			// (set) Token: 0x060051BC RID: 20924 RVA: 0x0003069E File Offset: 0x0002E89E
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

			// Token: 0x060051BD RID: 20925 RVA: 0x000306A1 File Offset: 0x0002E8A1
			[global::Cpp2ILInjected.Token(Token = "0x6004D49")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0AC8", Offset = "0x8C0AC8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public DifficultySliderPower()
			{
				throw null;
			}

			// Token: 0x060051BE RID: 20926 RVA: 0x000306A4 File Offset: 0x0002E8A4
			[global::Cpp2ILInjected.Token(Token = "0x6004D4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C0B54", Offset = "0x8C0B54", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void Reset()
			{
				throw null;
			}

			// Token: 0x060051BF RID: 20927 RVA: 0x000306A7 File Offset: 0x0002E8A7
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

			// Token: 0x060051C0 RID: 20928 RVA: 0x000306AA File Offset: 0x0002E8AA
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

			// Token: 0x060051C1 RID: 20929 RVA: 0x000306AD File Offset: 0x0002E8AD
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

			// Token: 0x060051C2 RID: 20930 RVA: 0x000306B0 File Offset: 0x0002E8B0
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

			// Token: 0x060051C3 RID: 20931 RVA: 0x000306B3 File Offset: 0x0002E8B3
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

			// Token: 0x060051C4 RID: 20932 RVA: 0x000306B6 File Offset: 0x0002E8B6
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

			// Token: 0x060051C5 RID: 20933 RVA: 0x000306B9 File Offset: 0x0002E8B9
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

			// Token: 0x060051C6 RID: 20934 RVA: 0x000306BC File Offset: 0x0002E8BC
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

			// Token: 0x060051C7 RID: 20935 RVA: 0x000306BF File Offset: 0x0002E8BF
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

			// Token: 0x060051C8 RID: 20936 RVA: 0x000306C2 File Offset: 0x0002E8C2
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

			// Token: 0x060051C9 RID: 20937 RVA: 0x000306C5 File Offset: 0x0002E8C5
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

			// Token: 0x060051CA RID: 20938 RVA: 0x000306C8 File Offset: 0x0002E8C8
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

			// Token: 0x060051CB RID: 20939 RVA: 0x000306CB File Offset: 0x0002E8CB
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

			// Token: 0x060051CC RID: 20940 RVA: 0x000306CE File Offset: 0x0002E8CE
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

			// Token: 0x060051CD RID: 20941 RVA: 0x000306D1 File Offset: 0x0002E8D1
			[global::Cpp2ILInjected.Token(Token = "0x6004D59")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1AAC", Offset = "0x8C1AAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x060051CE RID: 20942 RVA: 0x000306D4 File Offset: 0x0002E8D4
			[global::Cpp2ILInjected.Token(Token = "0x6004D5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1AB4", Offset = "0x8C1AB4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(BinaryWriter writer)
			{
				throw null;
			}

			// Token: 0x060051CF RID: 20943 RVA: 0x000306D7 File Offset: 0x0002E8D7
			[global::Cpp2ILInjected.Token(Token = "0x6004D5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1AD0", Offset = "0x8C1AD0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x060051D0 RID: 20944 RVA: 0x000306DA File Offset: 0x0002E8DA
			[global::Cpp2ILInjected.Token(Token = "0x6004D5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1B0C", Offset = "0x8C1B0C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x04008ED5 RID: 36565
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008699")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private float <StrengthMultiplierToGiveNPCs>k__BackingField;
		}

		// Token: 0x02000A95 RID: 2709
		[global::Cpp2ILInjected.Token(Token = "0x2000A45")]
		public class ModifyWindDirectionAndStrength : CreativePowers.ASharedSliderPower
		{
			// Token: 0x060051D1 RID: 20945 RVA: 0x000306DD File Offset: 0x0002E8DD
			[global::Cpp2ILInjected.Token(Token = "0x6004D5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1B20", Offset = "0x8C1B20", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public ModifyWindDirectionAndStrength()
			{
				throw null;
			}

			// Token: 0x060051D2 RID: 20946 RVA: 0x000306E0 File Offset: 0x0002E8E0
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

			// Token: 0x060051D3 RID: 20947 RVA: 0x000306E3 File Offset: 0x0002E8E3
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

			// Token: 0x060051D4 RID: 20948 RVA: 0x000306E6 File Offset: 0x0002E8E6
			[global::Cpp2ILInjected.Token(Token = "0x6004D60")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C1CDC", Offset = "0x8C1CDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x060051D5 RID: 20949 RVA: 0x000306E9 File Offset: 0x0002E8E9
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

			// Token: 0x060051D6 RID: 20950 RVA: 0x000306EC File Offset: 0x0002E8EC
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

			// Token: 0x060051D7 RID: 20951 RVA: 0x000306EF File Offset: 0x0002E8EF
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

			// Token: 0x060051D8 RID: 20952 RVA: 0x000306F2 File Offset: 0x0002E8F2
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

			// Token: 0x060051D9 RID: 20953 RVA: 0x000306F5 File Offset: 0x0002E8F5
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

			// Token: 0x060051DA RID: 20954 RVA: 0x000306F8 File Offset: 0x0002E8F8
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

			// Token: 0x060051DB RID: 20955 RVA: 0x000306FB File Offset: 0x0002E8FB
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

		// Token: 0x02000A96 RID: 2710
		[global::Cpp2ILInjected.Token(Token = "0x2000A46")]
		public class ModifyRainPower : CreativePowers.ASharedSliderPower
		{
			// Token: 0x060051DC RID: 20956 RVA: 0x000306FE File Offset: 0x0002E8FE
			[global::Cpp2ILInjected.Token(Token = "0x6004D68")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C26B0", Offset = "0x8C26B0", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public ModifyRainPower()
			{
				throw null;
			}

			// Token: 0x060051DD RID: 20957 RVA: 0x00030701 File Offset: 0x0002E901
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

			// Token: 0x060051DE RID: 20958 RVA: 0x00030704 File Offset: 0x0002E904
			[global::Cpp2ILInjected.Token(Token = "0x6004D6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C27E4", Offset = "0x8C27E4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal override float GetSliderValueInner()
			{
				throw null;
			}

			// Token: 0x060051DF RID: 20959 RVA: 0x00030707 File Offset: 0x0002E907
			[global::Cpp2ILInjected.Token(Token = "0x6004D6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C283C", Offset = "0x8C283C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x060051E0 RID: 20960 RVA: 0x0003070A File Offset: 0x0002E90A
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

			// Token: 0x060051E1 RID: 20961 RVA: 0x0003070D File Offset: 0x0002E90D
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

			// Token: 0x060051E2 RID: 20962 RVA: 0x00030710 File Offset: 0x0002E910
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

			// Token: 0x060051E3 RID: 20963 RVA: 0x00030713 File Offset: 0x0002E913
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

			// Token: 0x060051E4 RID: 20964 RVA: 0x00030716 File Offset: 0x0002E916
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

			// Token: 0x060051E5 RID: 20965 RVA: 0x00030719 File Offset: 0x0002E919
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

			// Token: 0x060051E6 RID: 20966 RVA: 0x0003071C File Offset: 0x0002E91C
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

		// Token: 0x02000A97 RID: 2711
		[global::Cpp2ILInjected.Token(Token = "0x2000A47")]
		public class FreezeTime : CreativePowers.ASharedTogglePower, IPersistentPerWorldContent
		{
			// Token: 0x060051E7 RID: 20967 RVA: 0x0003071F File Offset: 0x0002E91F
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

			// Token: 0x060051E8 RID: 20968 RVA: 0x00030722 File Offset: 0x0002E922
			[global::Cpp2ILInjected.Token(Token = "0x6004D74")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C31D4", Offset = "0x8C31D4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal override string GetButtonTextKey()
			{
				throw null;
			}

			// Token: 0x060051E9 RID: 20969 RVA: 0x00030725 File Offset: 0x0002E925
			[global::Cpp2ILInjected.Token(Token = "0x6004D75")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3214", Offset = "0x8C3214", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x060051EA RID: 20970 RVA: 0x00030728 File Offset: 0x0002E928
			[global::Cpp2ILInjected.Token(Token = "0x6004D76")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C321C", Offset = "0x8C321C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(BinaryWriter writer)
			{
				throw null;
			}

			// Token: 0x060051EB RID: 20971 RVA: 0x0003072B File Offset: 0x0002E92B
			[global::Cpp2ILInjected.Token(Token = "0x6004D77")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3234", Offset = "0x8C3234", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x060051EC RID: 20972 RVA: 0x0003072E File Offset: 0x0002E92E
			[global::Cpp2ILInjected.Token(Token = "0x6004D78")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3260", Offset = "0x8C3260", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x060051ED RID: 20973 RVA: 0x00030731 File Offset: 0x0002E931
			[global::Cpp2ILInjected.Token(Token = "0x6004D79")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3270", Offset = "0x8C3270", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FreezeTime()
			{
				throw null;
			}
		}

		// Token: 0x02000A98 RID: 2712
		[global::Cpp2ILInjected.Token(Token = "0x2000A48")]
		public class FreezeWindDirectionAndStrength : CreativePowers.ASharedTogglePower, IPersistentPerWorldContent
		{
			// Token: 0x060051EE RID: 20974 RVA: 0x00030734 File Offset: 0x0002E934
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

			// Token: 0x060051EF RID: 20975 RVA: 0x00030737 File Offset: 0x0002E937
			[global::Cpp2ILInjected.Token(Token = "0x6004D7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3310", Offset = "0x8C3310", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal override string GetButtonTextKey()
			{
				throw null;
			}

			// Token: 0x060051F0 RID: 20976 RVA: 0x0003073A File Offset: 0x0002E93A
			[global::Cpp2ILInjected.Token(Token = "0x6004D7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3350", Offset = "0x8C3350", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x060051F1 RID: 20977 RVA: 0x0003073D File Offset: 0x0002E93D
			[global::Cpp2ILInjected.Token(Token = "0x6004D7D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3358", Offset = "0x8C3358", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(BinaryWriter writer)
			{
				throw null;
			}

			// Token: 0x060051F2 RID: 20978 RVA: 0x00030740 File Offset: 0x0002E940
			[global::Cpp2ILInjected.Token(Token = "0x6004D7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3370", Offset = "0x8C3370", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x060051F3 RID: 20979 RVA: 0x00030743 File Offset: 0x0002E943
			[global::Cpp2ILInjected.Token(Token = "0x6004D7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C339C", Offset = "0x8C339C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x060051F4 RID: 20980 RVA: 0x00030746 File Offset: 0x0002E946
			[global::Cpp2ILInjected.Token(Token = "0x6004D80")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C33AC", Offset = "0x8C33AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FreezeWindDirectionAndStrength()
			{
				throw null;
			}
		}

		// Token: 0x02000A99 RID: 2713
		[global::Cpp2ILInjected.Token(Token = "0x2000A49")]
		public class FreezeRainPower : CreativePowers.ASharedTogglePower, IPersistentPerWorldContent
		{
			// Token: 0x060051F5 RID: 20981 RVA: 0x00030749 File Offset: 0x0002E949
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

			// Token: 0x060051F6 RID: 20982 RVA: 0x0003074C File Offset: 0x0002E94C
			[global::Cpp2ILInjected.Token(Token = "0x6004D82")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C344C", Offset = "0x8C344C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal override string GetButtonTextKey()
			{
				throw null;
			}

			// Token: 0x060051F7 RID: 20983 RVA: 0x0003074F File Offset: 0x0002E94F
			[global::Cpp2ILInjected.Token(Token = "0x6004D83")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C348C", Offset = "0x8C348C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x060051F8 RID: 20984 RVA: 0x00030752 File Offset: 0x0002E952
			[global::Cpp2ILInjected.Token(Token = "0x6004D84")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3494", Offset = "0x8C3494", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(BinaryWriter writer)
			{
				throw null;
			}

			// Token: 0x060051F9 RID: 20985 RVA: 0x00030755 File Offset: 0x0002E955
			[global::Cpp2ILInjected.Token(Token = "0x6004D85")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C34AC", Offset = "0x8C34AC", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x060051FA RID: 20986 RVA: 0x00030758 File Offset: 0x0002E958
			[global::Cpp2ILInjected.Token(Token = "0x6004D86")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C34D8", Offset = "0x8C34D8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x060051FB RID: 20987 RVA: 0x0003075B File Offset: 0x0002E95B
			[global::Cpp2ILInjected.Token(Token = "0x6004D87")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C34E8", Offset = "0x8C34E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FreezeRainPower()
			{
				throw null;
			}
		}

		// Token: 0x02000A9A RID: 2714
		[global::Cpp2ILInjected.Token(Token = "0x2000A4A")]
		public class StopBiomeSpreadPower : CreativePowers.ASharedTogglePower, IPersistentPerWorldContent
		{
			// Token: 0x060051FC RID: 20988 RVA: 0x0003075E File Offset: 0x0002E95E
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

			// Token: 0x060051FD RID: 20989 RVA: 0x00030761 File Offset: 0x0002E961
			[global::Cpp2ILInjected.Token(Token = "0x6004D89")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3588", Offset = "0x8C3588", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal override string GetButtonTextKey()
			{
				throw null;
			}

			// Token: 0x060051FE RID: 20990 RVA: 0x00030764 File Offset: 0x0002E964
			[global::Cpp2ILInjected.Token(Token = "0x6004D8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C35C8", Offset = "0x8C35C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x060051FF RID: 20991 RVA: 0x00030767 File Offset: 0x0002E967
			[global::Cpp2ILInjected.Token(Token = "0x6004D8B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C35D0", Offset = "0x8C35D0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(BinaryWriter writer)
			{
				throw null;
			}

			// Token: 0x06005200 RID: 20992 RVA: 0x0003076A File Offset: 0x0002E96A
			[global::Cpp2ILInjected.Token(Token = "0x6004D8C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C35E8", Offset = "0x8C35E8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x06005201 RID: 20993 RVA: 0x0003076D File Offset: 0x0002E96D
			[global::Cpp2ILInjected.Token(Token = "0x6004D8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3614", Offset = "0x8C3614", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x06005202 RID: 20994 RVA: 0x00030770 File Offset: 0x0002E970
			[global::Cpp2ILInjected.Token(Token = "0x6004D8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C3624", Offset = "0x8C3624", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public StopBiomeSpreadPower()
			{
				throw null;
			}
		}

		// Token: 0x02000A9B RID: 2715
		[global::Cpp2ILInjected.Token(Token = "0x2000A4B")]
		public class SpawnRateSliderPerPlayerPower : CreativePowers.APerPlayerSliderPower, IPersistentPerPlayerContent
		{
			// Token: 0x170008FE RID: 2302
			// (get) Token: 0x06005203 RID: 20995 RVA: 0x00030773 File Offset: 0x0002E973
			// (set) Token: 0x06005204 RID: 20996 RVA: 0x00030776 File Offset: 0x0002E976
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

			// Token: 0x06005205 RID: 20997 RVA: 0x00030779 File Offset: 0x0002E979
			[global::Cpp2ILInjected.Token(Token = "0x6004D91")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C363C", Offset = "0x8C363C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public SpawnRateSliderPerPlayerPower()
			{
				throw null;
			}

			// Token: 0x06005206 RID: 20998 RVA: 0x0003077C File Offset: 0x0002E97C
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

			// Token: 0x06005207 RID: 20999 RVA: 0x0003077F File Offset: 0x0002E97F
			[global::Cpp2ILInjected.Token(Token = "0x6004D93")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C37B0", Offset = "0x8C37B0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal override void UpdateInfoFromSliderValueCache()
			{
				throw null;
			}

			// Token: 0x06005208 RID: 21000 RVA: 0x00030782 File Offset: 0x0002E982
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

			// Token: 0x06005209 RID: 21001 RVA: 0x00030785 File Offset: 0x0002E985
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

			// Token: 0x0600520A RID: 21002 RVA: 0x00030788 File Offset: 0x0002E988
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

			// Token: 0x0600520B RID: 21003 RVA: 0x0003078B File Offset: 0x0002E98B
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

			// Token: 0x0600520C RID: 21004 RVA: 0x0003078E File Offset: 0x0002E98E
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

			// Token: 0x0600520D RID: 21005 RVA: 0x00030791 File Offset: 0x0002E991
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

			// Token: 0x0600520E RID: 21006 RVA: 0x00030794 File Offset: 0x0002E994
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

			// Token: 0x0600520F RID: 21007 RVA: 0x00030797 File Offset: 0x0002E997
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

			// Token: 0x06005210 RID: 21008 RVA: 0x0003079A File Offset: 0x0002E99A
			[global::Cpp2ILInjected.Token(Token = "0x6004D9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C41AC", Offset = "0x8C41AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool GetIsUnlocked()
			{
				throw null;
			}

			// Token: 0x06005211 RID: 21009 RVA: 0x0003079D File Offset: 0x0002E99D
			[global::Cpp2ILInjected.Token(Token = "0x6004D9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C41B4", Offset = "0x8C41B4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Save(Player player, BinaryWriter writer)
			{
				throw null;
			}

			// Token: 0x06005212 RID: 21010 RVA: 0x000307A0 File Offset: 0x0002E9A0
			[global::Cpp2ILInjected.Token(Token = "0x6004D9E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C41CC", Offset = "0x8C41CC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void ResetDataForNewPlayer(Player player)
			{
				throw null;
			}

			// Token: 0x06005213 RID: 21011 RVA: 0x000307A3 File Offset: 0x0002E9A3
			[global::Cpp2ILInjected.Token(Token = "0x6004D9F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C41DC", Offset = "0x8C41DC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				throw null;
			}

			// Token: 0x06005214 RID: 21012 RVA: 0x000307A6 File Offset: 0x0002E9A6
			[global::Cpp2ILInjected.Token(Token = "0x6004DA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C420C", Offset = "0x8C420C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "PushChangeAndSetSlider", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			public void ApplyLoadedDataToOutOfPlayerFields(Player player)
			{
				throw null;
			}

			// Token: 0x04008ED6 RID: 36566
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400869A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private float <StrengthMultiplierToGiveNPCs>k__BackingField;
		}
	}
}
