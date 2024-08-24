using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Localization;

// Token: 0x0200023C RID: 572
[global::Cpp2ILInjected.Token(Token = "0x20002F5")]
public class TutorialStep_06_Mining : TutorialStep
{
	// Token: 0x0600103C RID: 4156 RVA: 0x00024B96 File Offset: 0x00022D96
	[global::Cpp2ILInjected.Token(Token = "0x600118B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D14C", Offset = "0xA6D14C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		throw null;
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x00024B99 File Offset: 0x00022D99
	[global::Cpp2ILInjected.Token(Token = "0x600118C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D154", Offset = "0xA6D154", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public override string GetGuideString()
	{
		throw null;
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x00024B9C File Offset: 0x00022D9C
	[global::Cpp2ILInjected.Token(Token = "0x600118D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D1E4", Offset = "0xA6D1E4", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x00024B9F File Offset: 0x00022D9F
	[global::Cpp2ILInjected.Token(Token = "0x600118E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6D1F0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void OnItemPlaced(int itemId, int tileId)
	{
		throw null;
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x00024BA2 File Offset: 0x00022DA2
	[global::Cpp2ILInjected.Token(Token = "0x600118F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D1F4", Offset = "0xA6D1F4", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TutorialStep), Member = "GiveItem", MemberParameters = new object[]
	{
		typeof(short),
		typeof(int)
	}, ReturnType = typeof(void))]
	public override void OnGuideDialogueOpen()
	{
		throw null;
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x00024BA5 File Offset: 0x00022DA5
	[global::Cpp2ILInjected.Token(Token = "0x6001190")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6D25C", Offset = "0xA6D25C", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public override bool Update()
	{
		throw null;
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x00024BA8 File Offset: 0x00022DA8
	[global::Cpp2ILInjected.Token(Token = "0x6001191")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6B814", Offset = "0xA6B814", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TutorialStep_06_Mining()
	{
		throw null;
	}

	// Token: 0x04001B8B RID: 7051
	[global::Cpp2ILInjected.Token(Token = "0x400213F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool givenPickaxe;

	// Token: 0x04001B8C RID: 7052
	[global::Cpp2ILInjected.Token(Token = "0x4002140")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	private bool collectedOres;

	// Token: 0x04001B8D RID: 7053
	[global::Cpp2ILInjected.Token(Token = "0x4002141")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
	private bool givenFurnace;
}
