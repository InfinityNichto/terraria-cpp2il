using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameInput;

// Token: 0x02000227 RID: 551
[global::Cpp2ILInjected.Token(Token = "0x20002D4")]
public class LockOnHelperStaticData
{
	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00024968 File Offset: 0x00022B68
	[global::Cpp2ILInjected.Token(Token = "0x17000195")]
	public static LockOnHelperStaticData Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x60010B2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4C19C", Offset = "0xA4C19C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 121)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x0002496B File Offset: 0x00022B6B
	[global::Cpp2ILInjected.Token(Token = "0x60010B3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4C1E8", Offset = "0xA4C1E8", Length = "0xDC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public LockOnHelperStaticData()
	{
		throw null;
	}

	// Token: 0x04001A4C RID: 6732
	[global::Cpp2ILInjected.Token(Token = "0x4001FA1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public LockOnHelper.LockOnMode UseMode;

	// Token: 0x04001A4D RID: 6733
	[global::Cpp2ILInjected.Token(Token = "0x4001FA2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public bool _enabled;

	// Token: 0x04001A4E RID: 6734
	[global::Cpp2ILInjected.Token(Token = "0x4001FA3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
	public bool _canLockOn;

	// Token: 0x04001A4F RID: 6735
	[global::Cpp2ILInjected.Token(Token = "0x4001FA4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public List<int> _targets;

	// Token: 0x04001A50 RID: 6736
	[global::Cpp2ILInjected.Token(Token = "0x4001FA5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int _pickedTarget;

	// Token: 0x04001A51 RID: 6737
	[global::Cpp2ILInjected.Token(Token = "0x4001FA6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int _lifeTimeCounter;

	// Token: 0x04001A52 RID: 6738
	[global::Cpp2ILInjected.Token(Token = "0x4001FA7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int _lifeTimeArrowDisplay;

	// Token: 0x04001A53 RID: 6739
	[global::Cpp2ILInjected.Token(Token = "0x4001FA8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public int _threeDSTarget;

	// Token: 0x04001A54 RID: 6740
	[global::Cpp2ILInjected.Token(Token = "0x4001FA9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int _targetClosestTarget;

	// Token: 0x04001A55 RID: 6741
	[global::Cpp2ILInjected.Token(Token = "0x4001FAA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public bool ForceUsability;

	// Token: 0x04001A56 RID: 6742
	[global::Cpp2ILInjected.Token(Token = "0x4001FAB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
	public bool LockOnAvailable;

	// Token: 0x04001A57 RID: 6743
	[global::Cpp2ILInjected.Token(Token = "0x4001FAC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int _lastFrame;

	// Token: 0x04001A58 RID: 6744
	[global::Cpp2ILInjected.Token(Token = "0x4001FAD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float[,] _drawProgress;
}
