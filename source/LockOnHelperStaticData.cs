using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.GameInput;

[Cpp2IlInjected.Token(Token = "0x2000228")]
public class LockOnHelperStaticData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001A55")]
	public LockOnHelper.LockOnMode UseMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001A56")]
	public bool _enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4001A57")]
	public bool _canLockOn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001A58")]
	public List<int> _targets;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001A59")]
	public int _pickedTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001A5A")]
	public int _lifeTimeCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001A5B")]
	public int _lifeTimeArrowDisplay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001A5C")]
	public int _threeDSTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001A5D")]
	public int _targetClosestTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001A5E")]
	public bool ForceUsability;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4001A5F")]
	public bool LockOnAvailable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001A60")]
	public int _lastFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001A61")]
	public float[,] _drawProgress;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public static LockOnHelperStaticData Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000F90")]
		[Cpp2IlInjected.Address(RVA = "0x12DF748", Offset = "0x12DF748", VA = "0x12DF748")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000F91")]
	[Cpp2IlInjected.Address(RVA = "0x12DF2FC", Offset = "0x12DF2FC", VA = "0x12DF2FC")]
	public LockOnHelperStaticData()
	{
	}
}
