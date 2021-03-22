FROM unityci/editor:ubuntu-2019.4.20f1-linux-il2cpp-0.11.0 AS builder
ARG UNITY_USERNAME
ARG UNITY_PASSWORD
ARG UNITY_SERIAL
# AS builder
USER root
# Copy Unity Project
COPY . /Game
WORKDIR /Game
# Authenticate
RUN ["/bin/bash", "-c", "unity-editor -quit -batchmode -username $UNITY_USERNAME -password $UNITY_PASSWORD -serial $UNITY_SERIAL"]
# Compile Unity Project
RUN ["/bin/bash", "-c", "unity-editor -batchmode -stackTraceLogType Full -accept-apiupdate -nographics -projectPath . -executeMethod Builder.LinuxServerBuilder.build -quit"]

# In Another Docker Container
FROM ubuntu
# Expose Port
EXPOSE 7777/udp
EXPOSE 7777/tcp
# Copy Compiled Files
COPY --from=builder Game/Build/Server .
# Run Server
CMD ["./GameServer"]