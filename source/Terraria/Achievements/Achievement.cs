using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Terraria.GameContent.UI.Elements;
using Terraria.Initializers;
using Terraria.Localization;
using UnityEngine;

namespace Terraria.Achievements
{
	// Token: 0x0200048C RID: 1164
	[JsonObject(MemberSerialization.OptIn)]
	[global::Cpp2ILInjected.Token(Token = "0x2000690")]
	public class Achievement
	{
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x0002B1C0 File Offset: 0x000293C0
		[global::Cpp2ILInjected.Token(Token = "0x170006C9")]
		public AchievementCategory Category
		{
			[global::Cpp2ILInjected.Token(Token = "0x600381F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1436FA4", Offset = "0x1436FA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x060032F3 RID: 13043 RVA: 0x0002B1C3 File Offset: 0x000293C3
		// (remove) Token: 0x060032F4 RID: 13044 RVA: 0x0002B1C6 File Offset: 0x000293C6
		[global::Cpp2ILInjected.Token(Token = "0x14000041")]
		public event Achievement.AchievementCompleted OnCompleted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003820")]
			[global::Cpp2ILInjected.Address(RVA = "0x1436FAC", Offset = "0x1436FAC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Register", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003821")]
			[global::Cpp2ILInjected.Address(RVA = "0x1437048", Offset = "0x1437048", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060032F5 RID: 13045 RVA: 0x0002B1C9 File Offset: 0x000293C9
		[global::Cpp2ILInjected.Token(Token = "0x170006CA")]
		public bool HasTracker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003822")]
			[global::Cpp2ILInjected.Address(RVA = "0x14370E4", Offset = "0x14370E4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "AchievementDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "GetTrackerValues", ReturnType = typeof(Tuple<decimal, decimal>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x0002B1CC File Offset: 0x000293CC
		[global::Cpp2ILInjected.Token(Token = "0x6003823")]
		[global::Cpp2ILInjected.Address(RVA = "0x14370F4", Offset = "0x14370F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public IAchievementTracker GetTracker()
		{
			throw null;
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060032F7 RID: 13047 RVA: 0x0002B1CF File Offset: 0x000293CF
		[global::Cpp2ILInjected.Token(Token = "0x170006CB")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003824")]
			[global::Cpp2ILInjected.Address(RVA = "0x14370FC", Offset = "0x14370FC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "AchievementDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "SortEntry", MemberParameters = new object[]
			{
				typeof(Achievement),
				typeof(Achievement)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Load", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x0002B1D2 File Offset: 0x000293D2
		[global::Cpp2ILInjected.Token(Token = "0x6003825")]
		[global::Cpp2ILInjected.Address(RVA = "0x1437154", Offset = "0x1437154", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 115)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public Achievement(string name)
		{
			throw null;
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x0002B1D5 File Offset: 0x000293D5
		[global::Cpp2ILInjected.Token(Token = "0x6003826")]
		[global::Cpp2ILInjected.Address(RVA = "0x1437294", Offset = "0x1437294", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "ClearAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void ClearProgress()
		{
			throw null;
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x0002B1D8 File Offset: 0x000293D8
		[global::Cpp2ILInjected.Token(Token = "0x6003827")]
		[global::Cpp2ILInjected.Address(RVA = "0x1437464", Offset = "0x1437464", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Shutdown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Shutdown()
		{
			throw null;
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x0002B1DB File Offset: 0x000293DB
		[global::Cpp2ILInjected.Token(Token = "0x6003828")]
		[global::Cpp2ILInjected.Address(RVA = "0x14375B0", Offset = "0x14375B0", Length = "0xD00")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 62)]
		public void Load(Dictionary<string, JObject> conditions)
		{
			throw null;
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x0002B1DE File Offset: 0x000293DE
		[global::Cpp2ILInjected.Token(Token = "0x6003829")]
		[global::Cpp2ILInjected.Address(RVA = "0x14382B0", Offset = "0x14382B0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Achievement), Member = "AddConditions", MemberParameters = new object[] { typeof(AchievementCondition[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 117)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition.AchievementUpdate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = "add_OnComplete", MemberParameters = new object[] { typeof(AchievementCondition.AchievementUpdate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void AddCondition(AchievementCondition condition)
		{
			throw null;
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x0002B1E1 File Offset: 0x000293E1
		[global::Cpp2ILInjected.Token(Token = "0x600382A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1438528", Offset = "0x1438528", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(LocalUser))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void OnConditionComplete(AchievementCondition condition)
		{
			throw null;
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x0002B1E4 File Offset: 0x000293E4
		[global::Cpp2ILInjected.Token(Token = "0x600382B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14387C4", Offset = "0x14387C4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Achievement), Member = "UseTrackerFromCondition", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Achievement), Member = "UseConditionsCompletedTracker", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Achievement), Member = "UseConditionsCompletedTracker", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void UseTracker(IAchievementTracker tracker)
		{
			throw null;
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x0002B1E7 File Offset: 0x000293E7
		[global::Cpp2ILInjected.Token(Token = "0x600382C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1438898", Offset = "0x1438898", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "GetConditionTracker", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IAchievementTracker))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "UseTracker", MemberParameters = new object[] { typeof(IAchievementTracker) }, ReturnType = typeof(void))]
		public void UseTrackerFromCondition(string conditionName)
		{
			throw null;
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x0002B1EA File Offset: 0x000293EA
		[global::Cpp2ILInjected.Token(Token = "0x600382D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1438930", Offset = "0x1438930", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConditionsCompletedTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConditionsCompletedTracker), Member = "AddCondition", MemberParameters = new object[] { typeof(AchievementCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "UseTracker", MemberParameters = new object[] { typeof(IAchievementTracker) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void UseConditionsCompletedTracker()
		{
			throw null;
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x0002B1ED File Offset: 0x000293ED
		[global::Cpp2ILInjected.Token(Token = "0x600382E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1438C28", Offset = "0x1438C28", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConditionsCompletedTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConditionsCompletedTracker), Member = "AddCondition", MemberParameters = new object[] { typeof(AchievementCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "UseTracker", MemberParameters = new object[] { typeof(IAchievementTracker) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void UseConditionsCompletedTracker(params string[] conditions)
		{
			throw null;
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x0002B1F0 File Offset: 0x000293F0
		[global::Cpp2ILInjected.Token(Token = "0x600382F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1438CE8", Offset = "0x1438CE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ClearTracker()
		{
			throw null;
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x0002B1F3 File Offset: 0x000293F3
		[global::Cpp2ILInjected.Token(Token = "0x6003830")]
		[global::Cpp2ILInjected.Address(RVA = "0x14388B4", Offset = "0x14388B4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Achievement), Member = "UseTrackerFromCondition", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IAchievementTracker GetConditionTracker(string name)
		{
			throw null;
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x0002B1F6 File Offset: 0x000293F6
		[global::Cpp2ILInjected.Token(Token = "0x6003831")]
		[global::Cpp2ILInjected.Address(RVA = "0x1438D1C", Offset = "0x1438D1C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "AddCondition", MemberParameters = new object[] { typeof(AchievementCondition) }, ReturnType = typeof(void))]
		public void AddConditions(params AchievementCondition[] conditions)
		{
			throw null;
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x0002B1F9 File Offset: 0x000293F9
		[global::Cpp2ILInjected.Token(Token = "0x6003832")]
		[global::Cpp2ILInjected.Address(RVA = "0x1438D70", Offset = "0x1438D70", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "GetCondition", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public AchievementCondition GetCondition(string conditionName)
		{
			throw null;
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x0002B1FC File Offset: 0x000293FC
		[global::Cpp2ILInjected.Token(Token = "0x6003833")]
		[global::Cpp2ILInjected.Address(RVA = "0x1438DE0", Offset = "0x1438DE0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetCategory(AchievementCategory category)
		{
			throw null;
		}

		// Token: 0x04006515 RID: 25877
		[global::Cpp2ILInjected.Token(Token = "0x4007911")]
		private static int _totalAchievements;

		// Token: 0x04006516 RID: 25878
		[global::Cpp2ILInjected.Token(Token = "0x4007912")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		// Token: 0x04006517 RID: 25879
		[global::Cpp2ILInjected.Token(Token = "0x4007913")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly LocalizedText FriendlyName;

		// Token: 0x04006518 RID: 25880
		[global::Cpp2ILInjected.Token(Token = "0x4007914")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly LocalizedText Description;

		// Token: 0x04006519 RID: 25881
		[global::Cpp2ILInjected.Token(Token = "0x4007915")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public readonly int Id;

		// Token: 0x0400651A RID: 25882
		[global::Cpp2ILInjected.Token(Token = "0x4007916")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private AchievementCategory _category;

		// Token: 0x0400651B RID: 25883
		[global::Cpp2ILInjected.Token(Token = "0x4007917")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private IAchievementTracker _tracker;

		// Token: 0x0400651C RID: 25884
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007918")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Achievement.AchievementCompleted OnCompleted;

		// Token: 0x0400651D RID: 25885
		[JsonProperty("Conditions")]
		[global::Cpp2ILInjected.Token(Token = "0x4007919")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Dictionary<string, AchievementCondition> _conditions;

		// Token: 0x0400651E RID: 25886
		[global::Cpp2ILInjected.Token(Token = "0x400791A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int _completedCount;

		// Token: 0x02000939 RID: 2361
		// (Invoke) Token: 0x06004CA3 RID: 19619
		[global::Cpp2ILInjected.Token(Token = "0x2000691")]
		public delegate void AchievementCompleted(Achievement achievement);
	}
}
