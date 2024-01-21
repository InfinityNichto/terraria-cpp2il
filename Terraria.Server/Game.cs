using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Server;

[Cpp2IlInjected.Token(Token = "0x200039F")]
public class Game : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170005B2")]
	public GameComponentCollection Components
	{
		[Cpp2IlInjected.Token(Token = "0x6002DFF")]
		[Cpp2IlInjected.Address(RVA = "0x14DE6A0", Offset = "0x14DE6A0", VA = "0x14DE6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005B3")]
	public ContentManager Content
	{
		[Cpp2IlInjected.Token(Token = "0x6002E00")]
		[Cpp2IlInjected.Address(RVA = "0x14DE6A8", Offset = "0x14DE6A8", VA = "0x14DE6A8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002E01")]
		[Cpp2IlInjected.Address(RVA = "0x14DE6B0", Offset = "0x14DE6B0", VA = "0x14DE6B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005B4")]
	public GraphicsDevice GraphicsDevice
	{
		[Cpp2IlInjected.Token(Token = "0x6002E02")]
		[Cpp2IlInjected.Address(RVA = "0x14DE6B4", Offset = "0x14DE6B4", VA = "0x14DE6B4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005B5")]
	public TimeSpan InactiveSleepTime
	{
		[Cpp2IlInjected.Token(Token = "0x6002E03")]
		[Cpp2IlInjected.Address(RVA = "0x14DE6BC", Offset = "0x14DE6BC", VA = "0x14DE6BC")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E04")]
		[Cpp2IlInjected.Address(RVA = "0x14DE73C", Offset = "0x14DE73C", VA = "0x14DE73C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005B6")]
	public bool IsActive
	{
		[Cpp2IlInjected.Token(Token = "0x6002E05")]
		[Cpp2IlInjected.Address(RVA = "0x14DE740", Offset = "0x14DE740", VA = "0x14DE740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005B7")]
	public bool IsFixedTimeStep
	{
		[Cpp2IlInjected.Token(Token = "0x6002E06")]
		[Cpp2IlInjected.Address(RVA = "0x14DE748", Offset = "0x14DE748", VA = "0x14DE748")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E07")]
		[Cpp2IlInjected.Address(RVA = "0x14DE750", Offset = "0x14DE750", VA = "0x14DE750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005B8")]
	public bool IsMouseVisible
	{
		[Cpp2IlInjected.Token(Token = "0x6002E08")]
		[Cpp2IlInjected.Address(RVA = "0x14DE754", Offset = "0x14DE754", VA = "0x14DE754")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E09")]
		[Cpp2IlInjected.Address(RVA = "0x14DE75C", Offset = "0x14DE75C", VA = "0x14DE75C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005B9")]
	public GameServiceContainer Services
	{
		[Cpp2IlInjected.Token(Token = "0x6002E0A")]
		[Cpp2IlInjected.Address(RVA = "0x14DE760", Offset = "0x14DE760", VA = "0x14DE760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005BA")]
	public TimeSpan TargetElapsedTime
	{
		[Cpp2IlInjected.Token(Token = "0x6002E0B")]
		[Cpp2IlInjected.Address(RVA = "0x14DE768", Offset = "0x14DE768", VA = "0x14DE768")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E0C")]
		[Cpp2IlInjected.Address(RVA = "0x14DE7E8", Offset = "0x14DE7E8", VA = "0x14DE7E8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005BB")]
	public GameWindow Window
	{
		[Cpp2IlInjected.Token(Token = "0x6002E0D")]
		[Cpp2IlInjected.Address(RVA = "0x14DE7EC", Offset = "0x14DE7EC", VA = "0x14DE7EC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event EventHandler<EventArgs> Activated
	{
		[Cpp2IlInjected.Token(Token = "0x6002E0E")]
		[Cpp2IlInjected.Address(RVA = "0x14DE7F4", Offset = "0x14DE7F4", VA = "0x14DE7F4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002E0F")]
		[Cpp2IlInjected.Address(RVA = "0x14DE8A4", Offset = "0x14DE8A4", VA = "0x14DE8A4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event EventHandler<EventArgs> Deactivated
	{
		[Cpp2IlInjected.Token(Token = "0x6002E10")]
		[Cpp2IlInjected.Address(RVA = "0x14DE954", Offset = "0x14DE954", VA = "0x14DE954")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002E11")]
		[Cpp2IlInjected.Address(RVA = "0x14DEA04", Offset = "0x14DEA04", VA = "0x14DEA04")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event EventHandler<EventArgs> Disposed
	{
		[Cpp2IlInjected.Token(Token = "0x6002E12")]
		[Cpp2IlInjected.Address(RVA = "0x14DEAB4", Offset = "0x14DEAB4", VA = "0x14DEAB4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002E13")]
		[Cpp2IlInjected.Address(RVA = "0x14DEB64", Offset = "0x14DEB64", VA = "0x14DEB64")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event EventHandler<EventArgs> Exiting
	{
		[Cpp2IlInjected.Token(Token = "0x6002E14")]
		[Cpp2IlInjected.Address(RVA = "0x14DEC14", Offset = "0x14DEC14", VA = "0x14DEC14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002E15")]
		[Cpp2IlInjected.Address(RVA = "0x14DECC4", Offset = "0x14DECC4", VA = "0x14DECC4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002E16")]
	[Cpp2IlInjected.Address(RVA = "0x14DED74", Offset = "0x14DED74", VA = "0x14DED74", Slot = "5")]
	protected virtual bool BeginDraw()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E17")]
	[Cpp2IlInjected.Address(RVA = "0x14DED7C", Offset = "0x14DED7C", VA = "0x14DED7C", Slot = "6")]
	protected virtual void BeginRun()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E18")]
	[Cpp2IlInjected.Address(RVA = "0x14DED80", Offset = "0x14DED80", VA = "0x14DED80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E19")]
	[Cpp2IlInjected.Address(RVA = "0x14DED84", Offset = "0x14DED84", VA = "0x14DED84", Slot = "7")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E1A")]
	[Cpp2IlInjected.Address(RVA = "0x14DED88", Offset = "0x14DED88", VA = "0x14DED88", Slot = "8")]
	protected virtual void Draw(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E1B")]
	[Cpp2IlInjected.Address(RVA = "0x14DED8C", Offset = "0x14DED8C", VA = "0x14DED8C", Slot = "9")]
	protected virtual void EndDraw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E1C")]
	[Cpp2IlInjected.Address(RVA = "0x14DED90", Offset = "0x14DED90", VA = "0x14DED90", Slot = "10")]
	protected virtual void EndRun()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E1D")]
	[Cpp2IlInjected.Address(RVA = "0x14DED94", Offset = "0x14DED94", VA = "0x14DED94")]
	public void Exit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E1E")]
	[Cpp2IlInjected.Address(RVA = "0x14DED98", Offset = "0x14DED98", VA = "0x14DED98", Slot = "11")]
	protected virtual void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E1F")]
	[Cpp2IlInjected.Address(RVA = "0x14DED9C", Offset = "0x14DED9C", VA = "0x14DED9C", Slot = "12")]
	protected virtual void LoadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E20")]
	[Cpp2IlInjected.Address(RVA = "0x14DEDA0", Offset = "0x14DEDA0", VA = "0x14DEDA0", Slot = "13")]
	protected virtual void OnActivated(object sender, EventArgs args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E21")]
	[Cpp2IlInjected.Address(RVA = "0x14DEDA4", Offset = "0x14DEDA4", VA = "0x14DEDA4", Slot = "14")]
	protected virtual void OnDeactivated(object sender, EventArgs args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E22")]
	[Cpp2IlInjected.Address(RVA = "0x14DEDA8", Offset = "0x14DEDA8", VA = "0x14DEDA8", Slot = "15")]
	protected virtual void OnExiting(object sender, EventArgs args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E23")]
	[Cpp2IlInjected.Address(RVA = "0x14DEDAC", Offset = "0x14DEDAC", VA = "0x14DEDAC")]
	public void ResetElapsedTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E24")]
	[Cpp2IlInjected.Address(RVA = "0x14DEDB0", Offset = "0x14DEDB0", VA = "0x14DEDB0")]
	public void Run()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E25")]
	[Cpp2IlInjected.Address(RVA = "0x14DEDB4", Offset = "0x14DEDB4", VA = "0x14DEDB4")]
	public void RunOneFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E26")]
	[Cpp2IlInjected.Address(RVA = "0x14DEDB8", Offset = "0x14DEDB8", VA = "0x14DEDB8", Slot = "16")]
	protected virtual bool ShowMissingRequirementMessage(Exception exception)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002E27")]
	[Cpp2IlInjected.Address(RVA = "0x14DEDC0", Offset = "0x14DEDC0", VA = "0x14DEDC0")]
	public void SuppressDraw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E28")]
	[Cpp2IlInjected.Address(RVA = "0x14DEDC4", Offset = "0x14DEDC4", VA = "0x14DEDC4")]
	public void Tick()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E29")]
	[Cpp2IlInjected.Address(RVA = "0x14DEDC8", Offset = "0x14DEDC8", VA = "0x14DEDC8", Slot = "17")]
	protected virtual void UnloadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E2A")]
	[Cpp2IlInjected.Address(RVA = "0x14DEDCC", Offset = "0x14DEDCC", VA = "0x14DEDCC", Slot = "18")]
	protected virtual void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E2B")]
	[Cpp2IlInjected.Address(RVA = "0x14DEDD0", Offset = "0x14DEDD0", VA = "0x14DEDD0")]
	public Game()
	{
	}
}
