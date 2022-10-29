const Sequelize = require('sequelize');

const componenteSequelize = new Sequelize('systemqrcode', 'douglas', 'minhasenha', {
 dialect: 'mysql',
 host: '127.0.0.1',
 port: 3306
});

module.exports = componenteSequelize;