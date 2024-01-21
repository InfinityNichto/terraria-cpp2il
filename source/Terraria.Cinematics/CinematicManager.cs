using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics;

[Cpp2IlInjected.Token(Token = "0x2000527")]
public class CinematicManager
{
	[Cpp2IlInjected.Token(Token = "0x400687D")]
	public static CinematicManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400687E")]
	private List<Film> _films;

	[Cpp2IlInjected.Token(Token = "0x60038C7")]
	[Cpp2IlInjected.Address(RVA = "0x11AAB88", Offset = "0x11AAB88", VA = "0x11AAB88")]
	public void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038C8")]
	[Cpp2IlInjected.Address(RVA = "0x11AAE44", Offset = "0x11AAE44", VA = "0x11AAE44")]
	public void PlayFilm(Film film)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038C9")]
	[Cpp2IlInjected.Address(RVA = "0x11AAEA8", Offset = "0x11AAEA8", VA = "0x11AAEA8")]
	public void StopAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038CA")]
	[Cpp2IlInjected.Address(RVA = "0x11AAEAC", Offset = "0x11AAEAC", VA = "0x11AAEAC")]
	public CinematicManager()
	{
	}
}
