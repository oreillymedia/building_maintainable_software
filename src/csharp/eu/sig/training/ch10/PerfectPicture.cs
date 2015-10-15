using System;
using System.Drawing;
using eu.sig.training.ch06.simpledigitalcamera;

namespace eu.sig.training.ch10 {
    public class PerfectPicture {
        public static SimpleDigitalCamera camera = null;

        // tag::takePerfectPicture[]
        public const int DAYLIGHT_START = 6;

        public Image takePerfectPicture(int currentHour) {
            Image image;
            if (currentHour < PerfectPicture.DAYLIGHT_START) {
                camera.flashLightOn();
                image = camera.takeSnapshot();
                camera.flashLightOff();
            } else {
                image = camera.takeSnapshot();
            }
            return image;
        }
        // end::takePerfectPicture[]
    }
}