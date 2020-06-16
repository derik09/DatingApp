# stage 1
FROM node:10.14-alpine as node
WORKDIR /app
COPY . .
RUN npm install
RUN npm run build

# stage 2
FROM nginx:1.16.0-alpine as prod-stage
COPY --from=node /app/dist/DatingApp-SPA /usr/share/nginx/html
