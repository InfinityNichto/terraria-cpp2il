using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007AB")]
	public class CoinLossRevengeSystem
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003FEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x74BEE0", Offset = "0x74BEE0", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ReadVector2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem), Member = "AddMarker", MemberParameters = new object[] { typeof(CoinLossRevengeSystem.RevengeMarker) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void AddMarkerFromReader(BinaryReader reader)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FED")]
		[global::Cpp2ILInjected.Address(RVA = "0x74C1F8", Offset = "0x74C1F8", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem), Member = "AddMarkerFromReader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem), Member = "CacheEnemy", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void AddMarker(CoinLossRevengeSystem.RevengeMarker marker)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x74C334", Offset = "0x74C334", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAll", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void DestroyMarker(int markerUniqueID)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x74C4A8", Offset = "0x74C4A8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public CoinLossRevengeSystem()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x74C554", Offset = "0x74C554", Length = "0x3B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "CheckActive", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetLifePercent", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem), Member = "AddMarker", MemberParameters = new object[] { typeof(CoinLossRevengeSystem.RevengeMarker) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendCoinLossRevengeMarker", MemberParameters = new object[]
		{
			typeof(CoinLossRevengeSystem.RevengeMarker),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_GivenOrTypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void CacheEnemy(NPC npc)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x74C908", Offset = "0x74C908", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x74CA14", Offset = "0x74CA14", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x74D390", Offset = "0x74D390", Length = "0x758")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SpawnNPC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple[]), Member = "Create", MemberTypeParameters = new object[]
		{
			typeof(int),
			typeof(Rectangle),
			typeof(Rectangle)
		}, MemberParameters = new object[]
		{
			typeof(int),
			typeof(Rectangle),
			typeof(Rectangle)
		}, ReturnType = "System.Tuple`3<T1, T2, T3>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem), Member = "RemoveExpiredOrInvalidMarkers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = "WouldNPCBeDiscouraged", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = "SpawnEnemy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Except", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		public void CheckRespawns()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x74CAB8", Offset = "0x74CAB8", Length = "0x8D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem), Member = "CheckRespawns", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAll", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		private void RemoveExpiredOrInvalidMarkers()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x74E0E4", Offset = "0x74E0E4", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = "DrawMapIcon", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public CoinLossRevengeSystem.RevengeMarker DrawMapIcons(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, ref string unused)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x74E740", Offset = "0x74E740", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SyncConnectedPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendCoinLossRevengeMarker", MemberParameters = new object[]
		{
			typeof(CoinLossRevengeSystem.RevengeMarker),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void SendAllMarkersToPlayer(int plr)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003FF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x74E958", Offset = "0x74E958", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "buyPrice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static CoinLossRevengeSystem()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6003FF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x74EA50", Offset = "0x74EA50", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool <RemoveExpiredOrInvalidMarkers>b__20_0(CoinLossRevengeSystem.RevengeMarker x)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6003FF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x74EA94", Offset = "0x74EA94", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool <RemoveExpiredOrInvalidMarkers>b__20_3(CoinLossRevengeSystem.RevengeMarker x)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007DDA")]
		public static bool DisplayCaching;

		[global::Cpp2ILInjected.Token(Token = "0x4007DDB")]
		public static int MinimumCoinsForCaching;

		[global::Cpp2ILInjected.Token(Token = "0x4007DDC")]
		private const int PLAYER_BOX_WIDTH_INNER = 1968;

		[global::Cpp2ILInjected.Token(Token = "0x4007DDD")]
		private const int PLAYER_BOX_HEIGHT_INNER = 1200;

		[global::Cpp2ILInjected.Token(Token = "0x4007DDE")]
		private const int PLAYER_BOX_WIDTH_OUTER = 2608;

		[global::Cpp2ILInjected.Token(Token = "0x4007DDF")]
		private const int PLAYER_BOX_HEIGHT_OUTER = 1840;

		[global::Cpp2ILInjected.Token(Token = "0x4007DE0")]
		private static readonly Vector2 _playerBoxSizeInner;

		[global::Cpp2ILInjected.Token(Token = "0x4007DE1")]
		private static readonly Vector2 _playerBoxSizeOuter;

		[global::Cpp2ILInjected.Token(Token = "0x4007DE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<CoinLossRevengeSystem.RevengeMarker> _markers;

		[global::Cpp2ILInjected.Token(Token = "0x4007DE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly object _markersLock;

		[global::Cpp2ILInjected.Token(Token = "0x4007DE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _gameTime;

		[global::Cpp2ILInjected.Token(Token = "0x20007AC")]
		public class RevengeMarker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003FFA")]
			[global::Cpp2ILInjected.Address(RVA = "0x74DCF8", Offset = "0x74DCF8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetToExpire()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007B9")]
			public bool RespawnAttemptLocked
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003FFB")]
				[global::Cpp2ILInjected.Address(RVA = "0x74EAB8", Offset = "0x74EAB8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003FFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x74EAC0", Offset = "0x74EAC0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetRespawnAttemptLock(bool state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003FFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x74C098", Offset = "0x74C098", Length = "0x160")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem), Member = "AddMarkerFromReader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem), Member = "CacheEnemy", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = "CalculateExpirationTime", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public RevengeMarker(Vector2 coords, int npcNetId, float npcHPPercent, int npcType, int npcAiStyle, int coinValue, float baseValue, bool spawnedFromStatue, int gameTime, int uniqueID = -1)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003FFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x74ECB0", Offset = "0x74ECB0", Length = "0x210")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.CoinLossRevengeSystem.<>c", Member = "<RemoveExpiredOrInvalidMarkers>b__20_1", MemberParameters = new object[] { typeof(CoinLossRevengeSystem.RevengeMarker) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.CoinLossRevengeSystem.<>c", Member = "<RemoveExpiredOrInvalidMarkers>b__20_2", MemberParameters = new object[] { typeof(CoinLossRevengeSystem.RevengeMarker) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetNPCInvasionGroup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public bool IsInvalid()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003FFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x74EA74", Offset = "0x74EA74", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool IsExpired(int gameTime)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004000")]
			[global::Cpp2ILInjected.Address(RVA = "0x74EACC", Offset = "0x74EACC", Length = "0x1E4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(int),
				typeof(float),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(bool),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			private int CalculateExpirationTime(int gameCacheTime, int coinValue)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004001")]
			[global::Cpp2ILInjected.Address(RVA = "0x74DAE8", Offset = "0x74DAE8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
			public bool Intersects(Rectangle rectInner, Rectangle rectOuter)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004002")]
			[global::Cpp2ILInjected.Address(RVA = "0x74DD04", Offset = "0x74DD04", Length = "0x3E0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem), Member = "CheckRespawns", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_RevengeSystem), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
			{
				typeof(IEntitySource),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
			{
				typeof(int),
				typeof(NPCSpawnParams)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "TryGetValue", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(NetworkText),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "moneyPing", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_GivenOrTypeName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
			{
				typeof(string),
				typeof(byte),
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			public void SpawnEnemy()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004003")]
			[global::Cpp2ILInjected.Address(RVA = "0x74DB14", Offset = "0x74DB14", Length = "0x1E4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem), Member = "CheckRespawns", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "DespawnEncouragement_AIStyle2_FloatingEye_IsDiscouraged", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneUndergroundDesert", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "DespawnEncouragement_AIStyle3_Fighters_NotDiscouraged", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2),
				typeof(NPC)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public bool WouldNPCBeDiscouraged(Player playerTarget)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004004")]
			[global::Cpp2ILInjected.Address(RVA = "0x74E34C", Offset = "0x74E34C", Length = "0x3F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem), Member = "DrawMapIcons", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Vector2),
				typeof(Vector2),
				typeof(Rectangle?),
				typeof(float),
				typeof(float),
				typeof(ref string)
			}, ReturnType = typeof(CoinLossRevengeSystem.RevengeMarker))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Vector2),
				typeof(Rectangle?),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(float),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			public bool DrawMapIcon(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, int gameTime)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004005")]
			[global::Cpp2ILInjected.Address(RVA = "0x74EEC0", Offset = "0x74EEC0", Length = "0x1D8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CoinsSplit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "DrawMoney", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(string),
				typeof(float),
				typeof(float),
				typeof(int[]),
				typeof(bool),
				typeof(SpriteBatch)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void UseMouseOver(SpriteBatch spriteBatch, ref string mouseTextString, float drawScale = 1f)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007BA")]
			public int UniqueID
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004006")]
				[global::Cpp2ILInjected.Address(RVA = "0x74F098", Offset = "0x74F098", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004007")]
			[global::Cpp2ILInjected.Address(RVA = "0x74F0A0", Offset = "0x74F0A0", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(NetworkText),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "WriteVector2", MemberParameters = new object[]
			{
				typeof(BinaryWriter),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void WriteSelfTo(BinaryWriter writer)
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6004008")]
			[global::Cpp2ILInjected.Address(RVA = "0x74F1D4", Offset = "0x74F1D4", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "buyPrice", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			static RevengeMarker()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007DE5")]
			private static int _uniqueIDCounter;

			[global::Cpp2ILInjected.Token(Token = "0x4007DE6")]
			private static readonly int _expirationCompCopper;

			[global::Cpp2ILInjected.Token(Token = "0x4007DE7")]
			private static readonly int _expirationCompSilver;

			[global::Cpp2ILInjected.Token(Token = "0x4007DE8")]
			private static readonly int _expirationCompGold;

			[global::Cpp2ILInjected.Token(Token = "0x4007DE9")]
			private static readonly int _expirationCompPlat;

			[global::Cpp2ILInjected.Token(Token = "0x4007DEA")]
			private const int ONE_MINUTE = 3600;

			[global::Cpp2ILInjected.Token(Token = "0x4007DEB")]
			private const int ENEMY_BOX_WIDTH = 2160;

			[global::Cpp2ILInjected.Token(Token = "0x4007DEC")]
			private const int ENEMY_BOX_HEIGHT = 1440;

			[global::Cpp2ILInjected.Token(Token = "0x4007DED")]
			public static readonly Vector2 EnemyBoxSize;

			[global::Cpp2ILInjected.Token(Token = "0x4007DEE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly Vector2 _location;

			[global::Cpp2ILInjected.Token(Token = "0x4007DEF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly Rectangle _hitbox;

			[global::Cpp2ILInjected.Token(Token = "0x4007DF0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private readonly int _npcNetID;

			[global::Cpp2ILInjected.Token(Token = "0x4007DF1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private readonly float _npcHPPercent;

			[global::Cpp2ILInjected.Token(Token = "0x4007DF2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private readonly float _baseValue;

			[global::Cpp2ILInjected.Token(Token = "0x4007DF3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			private readonly int _coinsValue;

			[global::Cpp2ILInjected.Token(Token = "0x4007DF4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private readonly int _npcTypeAgainstDiscouragement;

			[global::Cpp2ILInjected.Token(Token = "0x4007DF5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			private readonly int _npcAIStyleAgainstDiscouragement;

			[global::Cpp2ILInjected.Token(Token = "0x4007DF6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private readonly int _expirationTime;

			[global::Cpp2ILInjected.Token(Token = "0x4007DF7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
			private readonly bool _spawnedFromStatue;

			[global::Cpp2ILInjected.Token(Token = "0x4007DF8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private readonly int _uniqueID;

			[global::Cpp2ILInjected.Token(Token = "0x4007DF9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			private bool _forceExpire;

			[global::Cpp2ILInjected.Token(Token = "0x4007DFA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D")]
			private bool _attemptedRespawn;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007AD")]
		private sealed class <>c__DisplayClass5_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004009")]
			[global::Cpp2ILInjected.Address(RVA = "0x74C4A0", Offset = "0x74C4A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass5_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600400A")]
			[global::Cpp2ILInjected.Address(RVA = "0x74F308", Offset = "0x74F308", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <DestroyMarker>b__0(CoinLossRevengeSystem.RevengeMarker x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007DFB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int markerUniqueID;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007AE")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600400B")]
			[global::Cpp2ILInjected.Address(RVA = "0x74F31C", Offset = "0x74F31C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600400C")]
			[global::Cpp2ILInjected.Address(RVA = "0x74F378", Offset = "0x74F378", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600400D")]
			[global::Cpp2ILInjected.Address(RVA = "0x74F380", Offset = "0x74F380", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = "IsInvalid", ReturnType = typeof(bool))]
			internal bool <RemoveExpiredOrInvalidMarkers>b__20_1(CoinLossRevengeSystem.RevengeMarker x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600400E")]
			[global::Cpp2ILInjected.Address(RVA = "0x74F388", Offset = "0x74F388", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = "IsInvalid", ReturnType = typeof(bool))]
			internal bool <RemoveExpiredOrInvalidMarkers>b__20_2(CoinLossRevengeSystem.RevengeMarker x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007DFC")]
			public static readonly CoinLossRevengeSystem.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4007DFD")]
			public static Func<CoinLossRevengeSystem.RevengeMarker, bool> <>9__20_1;

			[global::Cpp2ILInjected.Token(Token = "0x4007DFE")]
			public static Predicate<CoinLossRevengeSystem.RevengeMarker> <>9__20_2;
		}
	}
}
