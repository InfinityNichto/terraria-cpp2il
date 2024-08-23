using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000022 RID: 34
[global::Cpp2ILInjected.Token(Token = "0x200003C")]
[Serializable]
public class DrEditorProfile
{
	// Token: 0x060000D3 RID: 211 RVA: 0x00021DF1 File Offset: 0x0001FFF1
	[global::Cpp2ILInjected.Token(Token = "0x600014C")]
	[global::Cpp2ILInjected.Address(RVA = "0x704694", Offset = "0x704694", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public DrEditorProfile()
	{
		throw null;
	}

	// Token: 0x0400008B RID: 139
	[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string Name;

	// Token: 0x0400008C RID: 140
	[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string RootFolder;

	// Token: 0x0400008D RID: 141
	[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool HasMultiplayerPermission;

	// Token: 0x0400008E RID: 142
	[global::Cpp2ILInjected.Token(Token = "0x40000DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
	public bool HasChatPermission;

	// Token: 0x0400008F RID: 143
	[global::Cpp2ILInjected.Token(Token = "0x40000DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
	public bool HasUGCPermission;
}
