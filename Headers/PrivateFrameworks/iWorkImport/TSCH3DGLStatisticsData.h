/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

@class TSCH3DGLPointerCountedSet;

// Not exported
@interface TSCH3DGLStatisticsData : NSObject
{
    TSCH3DGLPointerCountedSet *mShadersUseCount;
    TSCH3DGLPointerCountedSet *mGeometryUseCount;
    unsigned long long mFrames;
}

+ (id)statisticsData;
@property(nonatomic) unsigned long long frames; // @synthesize frames=mFrames;
- (void)drawGeometry:(id)arg1;
- (void)activateShader:(id)arg1;
- (id)description;
- (void)dealloc;
- (id)init;

@end

