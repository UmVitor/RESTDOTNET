FROM mysql:5.7.22
EXPOSE 3306
COPY ./REST_API/db/migrations/ /home/database/
COPY ./REST_API/db/dataset/ /home/database/
COPY ./REST_API/ci/init_database.sh/ /docker-entrypoint-initdb.d/init_database.sh