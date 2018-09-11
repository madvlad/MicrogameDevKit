# Mobile Microgame Dev Kit 🎮
Development Kit for Microgames

# What is a Microgame?
[Original Definition](https://www.mariowiki.com/Microgame)

A microgame is a very short (roughly 8 seconds) game that has a single object. A microgame usually has a single input method and supplies 1 to 2 words max for instruction. [This simple example is taken from WarioWare Touched](https://www.mariowiki.com/Party_Popper). Since a microgame only lasts 8 seconds, they should be very easy to figure out how to beat.

# The Idea
- All templates provide basic gameplay logic to hack with
- All templates will be derived from the TimerTemplate to provide easy communication to game overall
- Template demonstrate different ways one might utilize the touchscreen to make a game
- Everything is royalty free or original

# Structure
The top level of the repo will be a list of folders for all the templates. Each template is a standalone Unity solution.

# To make
- Basic swipe game (Cutting a vegetable)
- Basic rub game (Erasing something with an eraser)
- Basic scribble game (Connect point A to point B with a line)
- Basic drag game (Drag puzzle piece into puzzle)

# Instructions for making a new microgame from scratch
- First import the FrameTemplate unity package
- Set build type to Android or iOS
- Set package name to 'com.gamejam.<yourNameHere>'
- Disable any rotation besides Portrait
- Handle 3 different difficulties of play (0 - easy, 1 - normal, 2 - hard)
- Remember to set the correct values in the MockCoreManager
