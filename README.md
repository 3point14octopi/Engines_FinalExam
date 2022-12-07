# Engines_FinalExam

Command Design Pattern Explanation:

The command pattern is used to manage the white pellets in the scene. The EatPellet command is sent when PAC-Man collides with a pellet, 
and ReplacePellet is sent if PAC-Man accidentally eats a red pellet. 
To do this, a base interface CommPattern is created, with void functions EatPellet and ReplacePellet. A child class, PelletCommand, is created, 
which implements definitions for these functions. In this case, EatPellet deactivates the pellet game object and Replace pellet re-activates it. 
The PManager singleton acts as the invoker for all command objects, or in the case of this scene, the pellet commands. When a pellet object 
registers a collision from PAC-Man, it sends a PelletCommand to the invoker via the EatPellet function. This will execute the pellet's EatPellet 
command, and push it to a stack for later use. 
If a red pellet is eaten, the ReplaceLast7 command will be called from the invoker. The invoker will take the last 7 (or fewer) commands 
from the stack, execute the ReplacePellet command, and then pop the command from the stack. 
