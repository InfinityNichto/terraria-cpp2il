using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002B2")]
public class GraphicsDevice
{
	[Cpp2IlInjected.Token(Token = "0x4001FA3")]
	public static GraphicsDevice Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001FA4")]
	private Viewport _viewport;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001FA5")]
	private Color _blendFactor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001FA6")]
	private bool _blendFactorDirty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001FA7")]
	private BlendState _blendState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001FA8")]
	private BlendState _actualBlendState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001FA9")]
	private bool _blendStateDirty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001FAA")]
	private BlendState _blendStateAdditive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001FAB")]
	private BlendState _blendStateAlphaBlend;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001FAC")]
	private BlendState _blendStateNonPremultiplied;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001FAD")]
	private BlendState _blendStateOpaque;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4001FAE")]
	private DepthStencilState _depthStencilState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001FAF")]
	private DepthStencilState _actualDepthStencilState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001FB0")]
	private bool _depthStencilStateDirty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001FB1")]
	private DepthStencilState _depthStencilStateDefault;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001FB2")]
	private DepthStencilState _depthStencilStateDepthRead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001FB3")]
	private DepthStencilState _depthStencilStateNone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001FB4")]
	private RasterizerState _rasterizerState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001FB5")]
	private RasterizerState _actualRasterizerState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4001FB6")]
	private bool _rasterizerStateDirty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4001FB7")]
	private RasterizerState _rasterizerStateCullClockwise;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4001FB8")]
	private RasterizerState _rasterizerStateCullCounterClockwise;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4001FB9")]
	private RasterizerState _rasterizerStateCullNone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4001FBA")]
	private Rectangle _scissorRectangle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4001FBB")]
	private bool _scissorRectangleDirty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4001FBC")]
	private readonly RenderTargetBinding[] _currentRenderTargetBindings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4001FBD")]
	private int _currentRenderTargetCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4001FBE")]
	private readonly RenderTargetBinding[] _tempRenderTargetBinding;

	[Cpp2IlInjected.Token(Token = "0x4001FC0")]
	private static readonly Color DiscardColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4001FC1")]
	internal Dictionary<int, Effect> EffectCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4001FC9")]
	private int _maxVertexBufferSlots;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4001FCA")]
	internal int MaxTextureSlots;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4001FCB")]
	internal int MaxVertexTextureSlots;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4001FCC")]
	public Texture2D[] Textures;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4001FCF")]
	private readonly GraphicsProfile _graphicsProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
	[Cpp2IlInjected.Token(Token = "0x4001FD1")]
	public bool CachedImmediateDrawMaterialActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4001FD2")]
	private EffectPass _cachedImmediateDrawEffect;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4001FD3")]
	private int _cachedImmediateDrawEffectState;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4001FD4")]
	private Material _cachedImmediateDrawMaterial;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4001FD5")]
	private Texture2D _cachedImmediateTexture0;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4001FD6")]
	private Texture2D _cachedImmediateTexture1;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4001FD7")]
	private List<Material[]> MaterialArrays;

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	internal GraphicsCapabilities GraphicsCapabilities
	{
		[Cpp2IlInjected.Token(Token = "0x6001634")]
		[Cpp2IlInjected.Address(RVA = "0x13A110C", Offset = "0x13A110C", VA = "0x13A110C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001635")]
		[Cpp2IlInjected.Address(RVA = "0x13A1114", Offset = "0x13A1114", VA = "0x13A1114")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	internal bool IsRenderTargetBound
	{
		[Cpp2IlInjected.Token(Token = "0x6001644")]
		[Cpp2IlInjected.Address(RVA = "0x13A1ABC", Offset = "0x13A1ABC", VA = "0x13A1ABC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	internal DepthFormat ActiveDepthFormat
	{
		[Cpp2IlInjected.Token(Token = "0x6001645")]
		[Cpp2IlInjected.Address(RVA = "0x13A1AD0", Offset = "0x13A1AD0", VA = "0x13A1AD0")]
		get
		{
			return default(DepthFormat);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	public GraphicsAdapter Adapter
	{
		[Cpp2IlInjected.Token(Token = "0x6001646")]
		[Cpp2IlInjected.Address(RVA = "0x13A1AF8", Offset = "0x13A1AF8", VA = "0x13A1AF8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001647")]
		[Cpp2IlInjected.Address(RVA = "0x13A1B00", Offset = "0x13A1B00", VA = "0x13A1B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	public RasterizerState RasterizerState
	{
		[Cpp2IlInjected.Token(Token = "0x600164E")]
		[Cpp2IlInjected.Address(RVA = "0x13A27D0", Offset = "0x13A27D0", VA = "0x13A27D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600164F")]
		[Cpp2IlInjected.Address(RVA = "0x13A24C4", Offset = "0x13A24C4", VA = "0x13A24C4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	public Color BlendFactor
	{
		[Cpp2IlInjected.Token(Token = "0x6001650")]
		[Cpp2IlInjected.Address(RVA = "0x13A27D8", Offset = "0x13A27D8", VA = "0x13A27D8")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6001651")]
		[Cpp2IlInjected.Address(RVA = "0x13A27E0", Offset = "0x13A27E0", VA = "0x13A27E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	public BlendState BlendState
	{
		[Cpp2IlInjected.Token(Token = "0x6001652")]
		[Cpp2IlInjected.Address(RVA = "0x13A2874", Offset = "0x13A2874", VA = "0x13A2874")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001653")]
		[Cpp2IlInjected.Address(RVA = "0x13A216C", Offset = "0x13A216C", VA = "0x13A216C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	public DepthStencilState DepthStencilState
	{
		[Cpp2IlInjected.Token(Token = "0x6001654")]
		[Cpp2IlInjected.Address(RVA = "0x13A287C", Offset = "0x13A287C", VA = "0x13A287C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001655")]
		[Cpp2IlInjected.Address(RVA = "0x13A233C", Offset = "0x13A233C", VA = "0x13A233C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	public DisplayMode DisplayMode
	{
		[Cpp2IlInjected.Token(Token = "0x600165D")]
		[Cpp2IlInjected.Address(RVA = "0x13A2160", Offset = "0x13A2160", VA = "0x13A2160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	public GraphicsDeviceStatus GraphicsDeviceStatus
	{
		[Cpp2IlInjected.Token(Token = "0x600165E")]
		[Cpp2IlInjected.Address(RVA = "0x13A29D4", Offset = "0x13A29D4", VA = "0x13A29D4")]
		get
		{
			return default(GraphicsDeviceStatus);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	public PresentationParameters PresentationParameters
	{
		[Cpp2IlInjected.Token(Token = "0x600165F")]
		[Cpp2IlInjected.Address(RVA = "0x13A29DC", Offset = "0x13A29DC", VA = "0x13A29DC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001660")]
		[Cpp2IlInjected.Address(RVA = "0x13A29E4", Offset = "0x13A29E4", VA = "0x13A29E4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	public Viewport Viewport
	{
		[Cpp2IlInjected.Token(Token = "0x6001661")]
		[Cpp2IlInjected.Address(RVA = "0x13A29EC", Offset = "0x13A29EC", VA = "0x13A29EC")]
		get
		{
			return default(Viewport);
		}
		[Cpp2IlInjected.Token(Token = "0x6001662")]
		[Cpp2IlInjected.Address(RVA = "0x13A2A20", Offset = "0x13A2A20", VA = "0x13A2A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	public GraphicsProfile GraphicsProfile
	{
		[Cpp2IlInjected.Token(Token = "0x6001663")]
		[Cpp2IlInjected.Address(RVA = "0x13A2A3C", Offset = "0x13A2A3C", VA = "0x13A2A3C")]
		get
		{
			return default(GraphicsProfile);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	public Rectangle ScissorRectangle
	{
		[Cpp2IlInjected.Token(Token = "0x6001664")]
		[Cpp2IlInjected.Address(RVA = "0x13A2A44", Offset = "0x13A2A44", VA = "0x13A2A44")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6001665")]
		[Cpp2IlInjected.Address(RVA = "0x13A26DC", Offset = "0x13A26DC", VA = "0x13A26DC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	public int RenderTargetCount
	{
		[Cpp2IlInjected.Token(Token = "0x6001666")]
		[Cpp2IlInjected.Address(RVA = "0x13A2A54", Offset = "0x13A2A54", VA = "0x13A2A54")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	public bool ResourcesLost
	{
		[Cpp2IlInjected.Token(Token = "0x600166A")]
		[Cpp2IlInjected.Address(RVA = "0x13A2AEC", Offset = "0x13A2AEC", VA = "0x13A2AEC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600166B")]
		[Cpp2IlInjected.Address(RVA = "0x13A2AF4", Offset = "0x13A2AF4", VA = "0x13A2AF4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event EventHandler<EventArgs> DeviceLost
	{
		[Cpp2IlInjected.Token(Token = "0x6001636")]
		[Cpp2IlInjected.Address(RVA = "0x13A111C", Offset = "0x13A111C", VA = "0x13A111C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001637")]
		[Cpp2IlInjected.Address(RVA = "0x13A11CC", Offset = "0x13A11CC", VA = "0x13A11CC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event EventHandler<EventArgs> DeviceReset
	{
		[Cpp2IlInjected.Token(Token = "0x6001638")]
		[Cpp2IlInjected.Address(RVA = "0x13A127C", Offset = "0x13A127C", VA = "0x13A127C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001639")]
		[Cpp2IlInjected.Address(RVA = "0x13A132C", Offset = "0x13A132C", VA = "0x13A132C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event EventHandler<EventArgs> DeviceResetting
	{
		[Cpp2IlInjected.Token(Token = "0x600163A")]
		[Cpp2IlInjected.Address(RVA = "0x13A13DC", Offset = "0x13A13DC", VA = "0x13A13DC")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600163B")]
		[Cpp2IlInjected.Address(RVA = "0x13A148C", Offset = "0x13A148C", VA = "0x13A148C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event EventHandler<ResourceCreatedEventArgs> ResourceCreated
	{
		[Cpp2IlInjected.Token(Token = "0x600163C")]
		[Cpp2IlInjected.Address(RVA = "0x13A153C", Offset = "0x13A153C", VA = "0x13A153C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600163D")]
		[Cpp2IlInjected.Address(RVA = "0x13A15EC", Offset = "0x13A15EC", VA = "0x13A15EC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event EventHandler<ResourceDestroyedEventArgs> ResourceDestroyed
	{
		[Cpp2IlInjected.Token(Token = "0x600163E")]
		[Cpp2IlInjected.Address(RVA = "0x13A169C", Offset = "0x13A169C", VA = "0x13A169C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600163F")]
		[Cpp2IlInjected.Address(RVA = "0x13A174C", Offset = "0x13A174C", VA = "0x13A174C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event EventHandler<EventArgs> Disposing
	{
		[Cpp2IlInjected.Token(Token = "0x6001640")]
		[Cpp2IlInjected.Address(RVA = "0x13A17FC", Offset = "0x13A17FC", VA = "0x13A17FC")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001641")]
		[Cpp2IlInjected.Address(RVA = "0x13A18AC", Offset = "0x13A18AC", VA = "0x13A18AC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	internal event EventHandler<PresentationEventArgs> PresentationChanged
	{
		[Cpp2IlInjected.Token(Token = "0x6001642")]
		[Cpp2IlInjected.Address(RVA = "0x13A195C", Offset = "0x13A195C", VA = "0x13A195C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001643")]
		[Cpp2IlInjected.Address(RVA = "0x13A1A0C", Offset = "0x13A1A0C", VA = "0x13A1A0C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001648")]
	[Cpp2IlInjected.Address(RVA = "0x13911E4", Offset = "0x13911E4", VA = "0x13911E4")]
	internal GraphicsDevice()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001649")]
	[Cpp2IlInjected.Address(RVA = "0x13A1F70", Offset = "0x13A1F70", VA = "0x13A1F70")]
	public GraphicsDevice(GraphicsAdapter adapter, GraphicsProfile graphicsProfile, PresentationParameters presentationParameters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600164A")]
	[Cpp2IlInjected.Address(RVA = "0x13A1B08", Offset = "0x13A1B08", VA = "0x13A1B08")]
	private void Setup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600164B")]
	[Cpp2IlInjected.Address(RVA = "0x13A26A4", Offset = "0x13A26A4", VA = "0x13A26A4", Slot = "1")]
	~GraphicsDevice()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600164C")]
	[Cpp2IlInjected.Address(RVA = "0x13A26AC", Offset = "0x13A26AC", VA = "0x13A26AC")]
	internal int GetClampedMultisampleCount(int multiSampleCount)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600164D")]
	[Cpp2IlInjected.Address(RVA = "0x13A1E10", Offset = "0x13A1E10", VA = "0x13A1E10")]
	internal void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001656")]
	[Cpp2IlInjected.Address(RVA = "0x13A2884", Offset = "0x13A2884", VA = "0x13A2884")]
	internal void ApplyState(bool applyShaders)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001657")]
	[Cpp2IlInjected.Address(RVA = "0x13A2888", Offset = "0x13A2888", VA = "0x13A2888")]
	public void Clear(Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001658")]
	[Cpp2IlInjected.Address(RVA = "0x13A288C", Offset = "0x13A288C", VA = "0x13A288C")]
	public void Clear(ClearOptions options, Color color, float depth, int stencil)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001659")]
	[Cpp2IlInjected.Address(RVA = "0x13A2890", Offset = "0x13A2890", VA = "0x13A2890")]
	public void Clear(ClearOptions options, Vector4 color, float depth, int stencil)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600165A")]
	[Cpp2IlInjected.Address(RVA = "0x13A2894", Offset = "0x13A2894", VA = "0x13A2894")]
	public void Present()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600165B")]
	[Cpp2IlInjected.Address(RVA = "0x13A2930", Offset = "0x13A2930", VA = "0x13A2930")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600165C")]
	[Cpp2IlInjected.Address(RVA = "0x13A2934", Offset = "0x13A2934", VA = "0x13A2934")]
	public void Reset(PresentationParameters presentationParameters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001667")]
	[Cpp2IlInjected.Address(RVA = "0x13A2A5C", Offset = "0x13A2A5C", VA = "0x13A2A5C")]
	public void SetRenderTarget(RenderTarget2D renderTarget)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001668")]
	[Cpp2IlInjected.Address(RVA = "0x13A2A60", Offset = "0x13A2A60", VA = "0x13A2A60")]
	public RenderTargetBinding[] GetRenderTargets()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001669")]
	[Cpp2IlInjected.Address(RVA = "0x13A2AD8", Offset = "0x13A2AD8", VA = "0x13A2AD8")]
	public void GetRenderTargets(RenderTargetBinding[] outTargets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600166C")]
	[Cpp2IlInjected.Address(RVA = "0x15F8580", Offset = "0x15F8580", VA = "0x15F8580")]
	private T[] Clone<T>(T[] srcArray, int Count)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600166D")]
	[Cpp2IlInjected.Address(RVA = "0x13A2AFC", Offset = "0x13A2AFC", VA = "0x13A2AFC")]
	public Material GetMaterial(int offset)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600166E")]
	[Cpp2IlInjected.Address(RVA = "0x13A2C90", Offset = "0x13A2C90", VA = "0x13A2C90")]
	public void DrawGeometry(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, Vector3 position, Vector3 scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600166F")]
	[Cpp2IlInjected.Address(RVA = "0x13A2D80", Offset = "0x13A2D80", VA = "0x13A2D80")]
	private Material[] GetMaterialArray(List<Material> subMeshMaterials)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001670")]
	[Cpp2IlInjected.Address(RVA = "0x13A2E94", Offset = "0x13A2E94", VA = "0x13A2E94")]
	public void DrawGeometryWithSubMeshes(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, Vector3 position, Vector3 scale, List<Material> subMeshMaterials, List<SubMeshDescriptor> subMeshPartitions)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001671")]
	[Cpp2IlInjected.Address(RVA = "0x13A3280", Offset = "0x13A3280", VA = "0x13A3280")]
	public void DrawGeometry(List<UnityEngine.Vector3> positions, List<UnityEngine.Vector2> uvs, List<UnityEngine.Vector4> uv2s, List<Color32> colours, List<int> indices, Vector3 position, Vector3 scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001672")]
	[Cpp2IlInjected.Address(RVA = "0x13A3370", Offset = "0x13A3370", VA = "0x13A3370")]
	internal static Rectangle GetDefaultTitleSafeArea(int x, int y, int width, int height)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6001673")]
	[Cpp2IlInjected.Address(RVA = "0x139A310", Offset = "0x139A310", VA = "0x139A310")]
	internal static Rectangle GetTitleSafeArea(int x, int y, int width, int height)
	{
		return default(Rectangle);
	}
}
