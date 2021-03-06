﻿// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections.Generic;
using CoreLocation;
using Foundation;
using MapKit;
using UIKit;

namespace SofiaApp.iOS
{
	public partial class MapView : UIView
	{
		public MKMapView Map { get; }

		public MapView (IntPtr handle) : base (handle)
		{
			Map = new MKMapView (UIScreen.MainScreen.Bounds);
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			AddSubview (Map);

			Map.TopAnchor.ConstraintEqualTo (TopAnchor, 0);
			Map.BottomAnchor.ConstraintEqualTo (BottomAnchor, 0);
			Map.LeftAnchor.ConstraintEqualTo (LeftAnchor, 0);
			Map.RightAnchor.ConstraintEqualTo (RightAnchor, 0);
			Map.MapType = MKMapType.Hybrid;
			Map.ZoomEnabled = true;
			Map.ScrollEnabled = true;

			MKCoordinateRegion mapRegion = new MKCoordinateRegion ();
			CLLocationCoordinate2D coordinate = new CLLocationCoordinate2D (39.458676, -0.340148);
			mapRegion.Center = coordinate;
			mapRegion.Span.LatitudeDelta = 0.2;
			mapRegion.Span.LongitudeDelta = 0.2;
			Map.SetRegion (mapRegion, true);
			Map.ShowsUserLocation = true;
		}
	}
}
