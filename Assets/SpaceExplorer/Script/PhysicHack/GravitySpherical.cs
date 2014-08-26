﻿using UnityEngine;
using System.Collections;

namespace SvenFrankson.Game.SpaceExplorer {

	public class GravitySpherical : Gravity {

		public override GravityType GType {
			get {
				return GravityType.Spherical;
			}
		}
	}
}
