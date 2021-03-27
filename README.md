# Unity Docker MLAPI Server Template
This is a Unity Template for a Multiplayer Server with MLAPI using Rufus and Docker for Server Hosting.
## Dependencies
- com.unity.toolchain.linux-x86_64

Do *not* install the other versions for other OS:
- com.unity.toolchain.macos-x86_64-linux-x86_64
- com.unity.toolchain.win-x86_64-linux-x86_64
## Usage
Write your Unity Credentials in an `.env` file in the root of the directory (where `docker-compose.yml` is).
```
UNITY_USERNAME=yourmail@mail.com
UNITY_PASSWORD=yourpassword
UNITY_SERIAL=yourserial
```
### Running Server in Docker
To use Docker just run `docker-compose up --build` and it will compile the project and run it in a docker container. 
### Running Clients
