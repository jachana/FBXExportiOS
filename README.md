# FBXExportiOS

## Instructions
### Download
* First clone the project into some directory in your computer
### Unity
* Inside Unity open the scene called SampleScene in Assets/Scene
* There are some things preselected, but you can change the model/path/filename, and make sure to change the model in the gameobject Exporter ![image](https://user-images.githubusercontent.com/2453138/191344704-47760c0e-bbb7-4b9d-a719-b78b9621d6f2.png)
* Build the project into a Xcode project

### Xcode
* Inside Xcode make sure your have your signature fixed Signature sin the Signing capabilities tab
* In the Info tab Add a key for "Application supports iTunes file sharing" and change the value to Yes ( this has to be done only once per Xcode Project)
* Build the Xcode Project

### Finder
* To find the fbx file
  * Go to finder
  * Select the iOS device 
  * Go to the Files tab
  * Select your app from the list
  * You will be able to download the files 
