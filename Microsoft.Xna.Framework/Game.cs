using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000275")]
public class Game : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001CBE")]
	private GameComponentCollection _components;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001CBF")]
	private ContentManager content;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001CC0")]
	private GraphicsDevice graphicsDevice;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001CC1")]
	private long totalTicks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001CC2")]
	private bool _active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4001CC3")]
	public bool IsMouseVisible;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4001CC4")]
	public bool IsFixedTimeStep;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001CC5")]
	private DateTime _lastUpdate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001CC6")]
	private DateTime _firstUpdate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001CC7")]
	private TimeSpan _totalTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001CC8")]
	private bool _initialised;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4001CC9")]
	private bool _uiHidden;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x4001CCA")]
	private bool _serverRunning;

	[Cpp2IlInjected.Token(Token = "0x4001CCB")]
	private static TimeSpan FrameTickTime;

	[Cpp2IlInjected.Token(Token = "0x4001CCC")]
	private static TimeSpan FrameClampTickTime;

	[Cpp2IlInjected.Token(Token = "0x4001CCD")]
	private static TimeSpan FrameIgnoreTime;

	[Cpp2IlInjected.Token(Token = "0x4001CCE")]
	private static GameTime RunGameTime;

	[Cpp2IlInjected.Token(Token = "0x4001CCF")]
	private static DateTime lastFrameUpdate;

	[Cpp2IlInjected.Token(Token = "0x4001CD0")]
	private static DateTime[] lastFrameTime;

	[Cpp2IlInjected.Token(Token = "0x4001CD1")]
	private static DateTime[] frameTime;

	[Cpp2IlInjected.Token(Token = "0x4001CD2")]
	private static int frameTimeCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x43")]
	[Cpp2IlInjected.Token(Token = "0x4001CD3")]
	private bool updateModeVariable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4001CD4")]
	private int updateCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001CD5")]
	private DateTime updateTimeStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001CD6")]
	private DateTime lastUpdateTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001CD7")]
	private int fpsCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001CD8")]
	private int slowFrameCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001CD9")]
	private int oddFrameCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4001CDA")]
	private bool highFrameRate;

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public ContentManager Content
	{
		[Cpp2IlInjected.Token(Token = "0x6001351")]
		[Cpp2IlInjected.Address(RVA = "0x1391160", Offset = "0x1391160", VA = "0x1391160")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001352")]
		[Cpp2IlInjected.Address(RVA = "0x1391168", Offset = "0x1391168", VA = "0x1391168")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public GraphicsDevice GraphicsDevice
	{
		[Cpp2IlInjected.Token(Token = "0x6001353")]
		[Cpp2IlInjected.Address(RVA = "0x1391170", Offset = "0x1391170", VA = "0x1391170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public bool IsActive
	{
		[Cpp2IlInjected.Token(Token = "0x6001354")]
		[Cpp2IlInjected.Address(RVA = "0x13913CC", Offset = "0x13913CC", VA = "0x13913CC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001355")]
		[Cpp2IlInjected.Address(RVA = "0x13913D4", Offset = "0x13913D4", VA = "0x13913D4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public GameComponentCollection Components
	{
		[Cpp2IlInjected.Token(Token = "0x6001358")]
		[Cpp2IlInjected.Address(RVA = "0x139159C", Offset = "0x139159C", VA = "0x139159C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public GameWindow Window
	{
		[Cpp2IlInjected.Token(Token = "0x6001366")]
		[Cpp2IlInjected.Address(RVA = "0x1392FD4", Offset = "0x1392FD4", VA = "0x1392FD4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public GameServiceContainer Services
	{
		[Cpp2IlInjected.Token(Token = "0x6001367")]
		[Cpp2IlInjected.Address(RVA = "0x1393038", Offset = "0x1393038", VA = "0x1393038")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001356")]
	[Cpp2IlInjected.Address(RVA = "0x13913DC", Offset = "0x13913DC", VA = "0x13913DC")]
	public Game()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001357")]
	[Cpp2IlInjected.Address(RVA = "0x1391598", Offset = "0x1391598", VA = "0x1391598", Slot = "5")]
	protected virtual void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001359")]
	[Cpp2IlInjected.Address(RVA = "0x13915A4", Offset = "0x13915A4", VA = "0x13915A4")]
	public void UnityAwake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600135A")]
	[Cpp2IlInjected.Address(RVA = "0x1391618", Offset = "0x1391618", VA = "0x1391618")]
	public void initialiseCallBack(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600135B")]
	[Cpp2IlInjected.Address(RVA = "0x139181C", Offset = "0x139181C", VA = "0x139181C")]
	public void UnityStart()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600135C")]
	[Cpp2IlInjected.Address(RVA = "0x139191C", Offset = "0x139191C", VA = "0x139191C")]
	public void UnityServerInitialise()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600135D")]
	[Cpp2IlInjected.Address(RVA = "0x1391A08", Offset = "0x1391A08", VA = "0x1391A08")]
	public void UnityServerShutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600135E")]
	[Cpp2IlInjected.Address(RVA = "0x1391A14", Offset = "0x1391A14", VA = "0x1391A14")]
	public void UnityServerUpdate(float elapsedTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600135F")]
	[Cpp2IlInjected.Address(RVA = "0x1391F08", Offset = "0x1391F08", VA = "0x1391F08")]
	public void UnityUpdate(float elapsedTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001360")]
	[Cpp2IlInjected.Address(RVA = "0x1392940", Offset = "0x1392940", VA = "0x1392940")]
	public void UnityDraw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001361")]
	[Cpp2IlInjected.Address(RVA = "0x1392FB4", Offset = "0x1392FB4", VA = "0x1392FB4", Slot = "6")]
	protected virtual void Draw(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001362")]
	[Cpp2IlInjected.Address(RVA = "0x1392FB8", Offset = "0x1392FB8", VA = "0x1392FB8", Slot = "7")]
	protected virtual void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001363")]
	[Cpp2IlInjected.Address(RVA = "0x1392FC8", Offset = "0x1392FC8", VA = "0x1392FC8", Slot = "8")]
	protected virtual void LoadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001364")]
	[Cpp2IlInjected.Address(RVA = "0x1392FCC", Offset = "0x1392FCC", VA = "0x1392FCC", Slot = "9")]
	protected virtual void UnloadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001365")]
	[Cpp2IlInjected.Address(RVA = "0x1392FD0", Offset = "0x1392FD0", VA = "0x1392FD0", Slot = "10")]
	protected virtual void Exit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001368")]
	[Cpp2IlInjected.Address(RVA = "0x13930D8", Offset = "0x13930D8", VA = "0x13930D8")]
	internal void Run()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001369")]
	[Cpp2IlInjected.Address(RVA = "0x1393150", Offset = "0x1393150", VA = "0x1393150", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600136A")]
	[Cpp2IlInjected.Address(RVA = "0x1393154", Offset = "0x1393154", VA = "0x1393154")]
	internal void Begin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600136B")]
	[Cpp2IlInjected.Address(RVA = "0x1393158", Offset = "0x1393158", VA = "0x1393158")]
	internal void Tick(float deltaTime)
	{
	}
}
