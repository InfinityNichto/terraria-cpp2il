using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Capture;

[Cpp2IlInjected.Token(Token = "0x200050A")]
public class CaptureManager : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40067FD")]
	public static CaptureManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40067FE")]
	private CaptureInterface _interface;

	[Cpp2IlInjected.Token(Token = "0x170006F6")]
	public bool IsCapturing
	{
		[Cpp2IlInjected.Token(Token = "0x60037F8")]
		[Cpp2IlInjected.Address(RVA = "0x15070E4", Offset = "0x15070E4", VA = "0x15070E4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006F7")]
	public bool Active
	{
		[Cpp2IlInjected.Token(Token = "0x60037FA")]
		[Cpp2IlInjected.Address(RVA = "0x1507160", Offset = "0x1507160", VA = "0x1507160")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60037FB")]
		[Cpp2IlInjected.Address(RVA = "0x150716C", Offset = "0x150716C", VA = "0x150716C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006F8")]
	public bool UsingMap
	{
		[Cpp2IlInjected.Token(Token = "0x60037FC")]
		[Cpp2IlInjected.Address(RVA = "0x1507220", Offset = "0x1507220", VA = "0x1507220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60037F9")]
	[Cpp2IlInjected.Address(RVA = "0x15070EC", Offset = "0x15070EC", VA = "0x15070EC")]
	public CaptureManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037FD")]
	[Cpp2IlInjected.Address(RVA = "0x150723C", Offset = "0x150723C", VA = "0x150723C")]
	public void Scrolling()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037FE")]
	[Cpp2IlInjected.Address(RVA = "0x1507248", Offset = "0x1507248", VA = "0x1507248")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037FF")]
	[Cpp2IlInjected.Address(RVA = "0x1507254", Offset = "0x1507254", VA = "0x1507254")]
	public void Draw(SpriteBatch sb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003800")]
	[Cpp2IlInjected.Address(RVA = "0x1507260", Offset = "0x1507260", VA = "0x1507260")]
	public float GetProgress()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003801")]
	[Cpp2IlInjected.Address(RVA = "0x1507268", Offset = "0x1507268", VA = "0x1507268")]
	public void Capture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003802")]
	[Cpp2IlInjected.Address(RVA = "0x15077CC", Offset = "0x15077CC", VA = "0x15077CC")]
	public void Capture(CaptureSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003803")]
	[Cpp2IlInjected.Address(RVA = "0x15077D0", Offset = "0x15077D0", VA = "0x15077D0")]
	public void DrawTick()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003804")]
	[Cpp2IlInjected.Address(RVA = "0x15077D4", Offset = "0x15077D4", VA = "0x15077D4", Slot = "4")]
	public void Dispose()
	{
	}
}
