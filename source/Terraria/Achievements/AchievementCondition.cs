using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Terraria.GameContent.Achievements;

namespace Terraria.Achievements
{
	[JsonObject(MemberSerialization.OptIn)]
	[global::Cpp2ILInjected.Token(Token = "0x2000693")]
	public abstract class AchievementCondition
	{
		[global::Cpp2ILInjected.Token(Token = "0x14000042")]
		public event AchievementCondition.AchievementUpdate OnComplete
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003838")]
			[global::Cpp2ILInjected.Address(RVA = "0x143848C", Offset = "0x143848C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Achievement), Member = "AddCondition", MemberParameters = new object[] { typeof(AchievementCondition) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConditionsCompletedTracker), Member = "AddCondition", MemberParameters = new object[] { typeof(AchievementCondition) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003839")]
			[global::Cpp2ILInjected.Address(RVA = "0x1438F54", Offset = "0x1438F54", Length = "0x9C")]
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

		[global::Cpp2ILInjected.Token(Token = "0x170006CC")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x600383A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1438FF0", Offset = "0x1438FF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600383B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1438FF8", Offset = "0x1438FF8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomFlagCondition), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomFlagCondition), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomFloatCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomFloatCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomIntCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomIntCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemCraftCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemCraftCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemPickupCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemPickupCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKilledCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKilledCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProgressionEventCondition), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProgressionEventCondition), Member = ".ctor", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDestroyedCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(ushort[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AchievementCondition(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600383C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1439020", Offset = "0x1439020", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomFloatCondition), Member = "Load", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomIntCondition), Member = "Load", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void Load(JObject state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600383D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14390BC", Offset = "0x14390BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Shutdown()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600383E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14390C0", Offset = "0x14390C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomFloatCondition), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomIntCondition), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public virtual void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600383F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14390C8", Offset = "0x14390C8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomFloatCondition), Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomIntCondition), Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Complete()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003840")]
		[global::Cpp2ILInjected.Address(RVA = "0x14390F8", Offset = "0x14390F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual IAchievementTracker CreateAchievementTracker()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003841")]
		[global::Cpp2ILInjected.Address(RVA = "0x1438CF0", Offset = "0x1438CF0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public IAchievementTracker GetAchievementTracker()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007921")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007922")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private AchievementCondition.AchievementUpdate OnComplete;

		[global::Cpp2ILInjected.Token(Token = "0x4007923")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected IAchievementTracker _tracker;

		[JsonProperty("Completed")]
		[global::Cpp2ILInjected.Token(Token = "0x4007924")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _isCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x2000694")]
		public delegate void AchievementUpdate(AchievementCondition condition);
	}
}
