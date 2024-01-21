using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.CameraModifiers;

[Cpp2IlInjected.Token(Token = "0x200050F")]
public class PunchCameraModifier : ICameraModifier
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400680A")]
	private int _framesToLast;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400680B")]
	private Vector2 _startPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400680C")]
	private Vector2 _direction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400680D")]
	private float _distanceFalloff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400680E")]
	private float _strength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400680F")]
	private float _vibrationCyclesPerSecond;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006810")]
	private int _framesLasted;

	[Cpp2IlInjected.Token(Token = "0x170006FB")]
	public string UniqueIdentity
	{
		[Cpp2IlInjected.Token(Token = "0x6003810")]
		[Cpp2IlInjected.Address(RVA = "0x1312894", Offset = "0x1312894", VA = "0x1312894", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003811")]
		[Cpp2IlInjected.Address(RVA = "0x131289C", Offset = "0x131289C", VA = "0x131289C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006FC")]
	public bool Finished
	{
		[Cpp2IlInjected.Token(Token = "0x6003812")]
		[Cpp2IlInjected.Address(RVA = "0x13128A4", Offset = "0x13128A4", VA = "0x13128A4", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003813")]
		[Cpp2IlInjected.Address(RVA = "0x13128AC", Offset = "0x13128AC", VA = "0x13128AC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003814")]
	[Cpp2IlInjected.Address(RVA = "0x13128B4", Offset = "0x13128B4", VA = "0x13128B4")]
	public PunchCameraModifier(Vector2 startPosition, Vector2 direction, float strength, float vibrationCyclesPerSecond, int frames, float distanceFalloff = -1f, [Optional] string uniqueIdentity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003815")]
	[Cpp2IlInjected.Address(RVA = "0x1312914", Offset = "0x1312914", VA = "0x1312914", Slot = "5")]
	public void Update(ref CameraInfo cameraInfo)
	{
	}
}
