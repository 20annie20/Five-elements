# Five-elements - efficiently running mobile game with many objects-blocks
* Mobile game dedicated for devices with Android OS.
* Isometric, cute pixel-art, stylized as retro (I am not by any means a graphic artist I used only free assets, modifying them slightly to fit the aesthetics - it is still far from good though, especially UI could use some extra attention):
 
![image](https://user-images.githubusercontent.com/41429556/161133096-d3184c75-7b33-4076-b4d4-3ae6d2c99b02.png)

* It's an adventure RPG demo - implements mechanics of buying items like skins, picking up coins and passing levels
* I focused on creating proper physics, rendering and movement system for the three isometric terrain maps (the blocks only render correctly in game so no real way of displaying the whole map properly - we all love Unity :] ):

<img src="https://user-images.githubusercontent.com/41429556/161133477-7e605cfb-54fc-438e-8837-39c3a70ab4f2.png" alt="drawing" width="500"/>
<img src="https://user-images.githubusercontent.com/41429556/161133888-7897cb8c-dc68-4b41-b3a6-ae693b3376a7.png" alt="drawing" width="500"/>
<img src="https://user-images.githubusercontent.com/41429556/161135112-70e5fe18-a1cd-4c70-a146-18786d5ef7cd.png" alt="drawing" width="500"/>


* There's also very cute music and sounds too! I found it in other indie game and the license for any type of usage was free ;) .
* Very important thing for this project - since I was using Unity's tile system, the key to all this working was a special Atlas object which contained all the sprites and made the rendering of many many blocks fast and effective and the level building process was really fast once everything started working as supposed. There are few moments were the tiles are not behaving as expected ( I suggest using some fancier assets, maybe buy something that is more size-consistent - I struggled a lot with cutting blocks myself).

## out of scope of this project (//TODO after retirement)
•	external save system (in phone's memory, now it's just per app session)
•	players leaderboard (connection with external database)
•	fighting enemies
•	adding fabular plot and more levels
