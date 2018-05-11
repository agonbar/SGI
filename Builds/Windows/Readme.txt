
Notes:

– Executable file name should not contain white spaces or non-English symbols.
– Project path should not contain white spaces or non-English symbols.
– Path to application (in time of its launch) should not contain white spaces or non-English symbols.

– Always use a very bright light, which you can afford.
  In poor lighting conditions – the driver of the camera starts glue the frames of two or three to correct the exposure level, it lowers camera FPS.

===============================================================================================================================

– Please use USB 3.0 (3.1) webcams to get smooth and fast image tracking.

===============================================================================================================================

– If you will see the notification - "Could not connect to this camera", please try the x86 app.

===============================================================================================================================

– When you have multiple cameras connected - the upper camera will be selected first.

– If you want to try second or third camera, you need to unplug unused camera or remove unused cameras from the config file.

– How to edit config file?

1. Launch the app and setup the camera properties. (X-Y)
2. Click to "Save" Button
3. Close the app.

4. Open the configuration text file in the build folder - 
   "Vuforia_Standalone_6X_Data\StreamingAssets\QCAR\profiles.dat" and remove unused cameras. (don't delete the last empty line)

If you have administrator privileges on this machine – there is another config file
 "C:\Users\USER_NAME\AppData\LocalLow\CVLAB\Vuforia Standalone 6_X\profiles.dat"

– In this case you need to remove unused cameras in both files.

===============================================================================================================================

