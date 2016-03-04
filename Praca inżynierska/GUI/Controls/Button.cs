﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Audio;
using SFML.System;
using SFML.Window;
using static PracaInzynierska.Textures.LoadedTextures.GUITextures;

namespace PracaInzynierska.GUI.Controls {
	class Button : GUIElement {

		Button(Vector2f position, Image buttonImage) : base() {
			ButtonTexture = new Sprite(new Texture(buttonImage));
			ButtonTexture.Position = position;
		}

		override public void Draw(RenderTarget target, RenderStates states) {
			target.Draw(ButtonTexture);
		}

		public int Size { get; private set; }

		/// <summary>
		/// Obiekt slozacy do rysowania pola
		/// </summary>
		public Sprite ButtonTexture { get; internal set; }


	}
}
