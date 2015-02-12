using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;

namespace RFQuiltLayout {

	// @protocol RFQuiltLayoutDelegate <UICollectionViewDelegate>
	[BaseType(typeof(UICollectionViewDelegate))]
	[Model]
	public partial interface RFQuiltLayoutDelegate  {

		// @optional -(CGSize)collectionView:(UICollectionView *)collectionView layout:(UICollectionViewLayout *)collectionViewLayout blockSizeForItemAtIndexPath:(NSIndexPath *)indexPath;
		[Export ("collectionView:layout:blockSizeForItemAtIndexPath:")]
		CGSize Layout (UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, NSIndexPath indexPath);

//		// @optional -(UIEdgeInsets)collectionView:(UICollectionView *)collectionView layout:(UICollectionViewLayout *)collectionViewLayout insetsForItemAtIndexPath:(NSIndexPath *)indexPath;
//		[Export ("collectionView:layout:insetsForItemAtIndexPath:")]
//		UIEdgeInsets Layout (UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, NSIndexPath indexPath);
	}

	// @interface RFQuiltLayout : UICollectionViewLayout
	[BaseType (typeof (UICollectionViewLayout))]
	public partial interface RFQuiltLayout {

		// @property (nonatomic, weak) NSObject<RFQuiltLayoutDelegate> * delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) NSObject<RFQuiltLayoutDelegate> * delegate;
		[Wrap ("WeakDelegate")]
		NSObject Delegate { get; set; }

		// @property (assign, nonatomic) CGSize blockPixels;
		[Export ("blockPixels", ArgumentSemantic.UnsafeUnretained)]
		CGSize BlockPixels { get; set; }

		// @property (assign, nonatomic) UICollectionViewScrollDirection direction;
		[Export ("direction", ArgumentSemantic.UnsafeUnretained)]
		UICollectionViewScrollDirection Direction { get; set; }

		// @property (nonatomic) BOOL prelayoutEverything;
		[Export ("prelayoutEverything")]
		bool PrelayoutEverything { get; set; }
	}
}

