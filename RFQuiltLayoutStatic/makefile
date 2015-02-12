XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/RFQuiltLayoutStatic.xcodeproj
TARGET=RFQuiltLayoutStatic

all: libRFQuiltLayoutStatic.a

libRFQuiltLayoutStatic-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libRFQuiltLayoutStatic-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libRFQuiltLayoutStatic-armv7s.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libRFQuiltLayoutStatic-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libRFQuiltLayoutStatic.a: libRFQuiltLayoutStatic-i386.a libRFQuiltLayoutStatic-armv7.a libRFQuiltLayoutStatic-armv7s.a libRFQuiltLayoutStatic-arm64.a
	lipo -create -output $@ $^

sharpie:
	sharpie bind --output=RFQuiltLayout --namespace=RFQuiltLayout --sdk=iphoneos8.1 RFQuiltLayout.h --unified

clean:
	-rm -f *.a *.dll



# libRFQuiltLayoutStatic.a