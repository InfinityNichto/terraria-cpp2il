using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000631 RID: 1585
	[global::Cpp2ILInjected.Token(Token = "0x2000954")]
	public class RareSpawnBestiaryInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
	{
		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06003EB8 RID: 16056 RVA: 0x0002D32C File Offset: 0x0002B52C
		// (set) Token: 0x06003EB9 RID: 16057 RVA: 0x0002D32F File Offset: 0x0002B52F
		[global::Cpp2ILInjected.Token(Token = "0x17000824")]
		public int RarityLevel
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x81CA80", Offset = "0x81CA80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x81CA88", Offset = "0x81CA88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x0002D332 File Offset: 0x0002B532
		[global::Cpp2ILInjected.Token(Token = "0x60047CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x819BB8", Offset = "0x819BB8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RareSpawnBestiaryInfoElement(int rarityLevel)
		{
			throw null;
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x0002D335 File Offset: 0x0002B535
		[global::Cpp2ILInjected.Token(Token = "0x60047CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x81CA90", Offset = "0x81CA90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x0002D338 File Offset: 0x0002B538
		[global::Cpp2ILInjected.Token(Token = "0x60047D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x81CA98", Offset = "0x81CA98", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x04006C6D RID: 27757
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400838C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <RarityLevel>k__BackingField;
	}
}
