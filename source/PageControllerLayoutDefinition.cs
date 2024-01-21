using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200019E")]
public class PageControllerLayoutDefinition<T> : LayoutDefinition where T : PageControllerLayoutDefinition<T>
{
	[Cpp2IlInjected.Token(Token = "0x4001198")]
	public static T InstanceNormal;

	[Cpp2IlInjected.Token(Token = "0x4001199")]
	public static T InstanceConsoleLeft;

	[Cpp2IlInjected.Token(Token = "0x400119A")]
	public static T InstanceConsoleRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400119B")]
	private bool _rightPageController;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public static T Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x19761F8", Offset = "0x19761F8", VA = "0x19761F8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool RightPageController
	{
		[Cpp2IlInjected.Token(Token = "0x6000BEA")]
		[Cpp2IlInjected.Address(RVA = "0x19762EC", Offset = "0x19762EC", VA = "0x19762EC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x19762F4", Offset = "0x19762F4", VA = "0x19762F4")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEC")]
	[Cpp2IlInjected.Address(RVA = "0x197650C", Offset = "0x197650C", VA = "0x197650C")]
	public PageControllerLayoutDefinition()
	{
	}
}
