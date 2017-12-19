const userController = require('./../controllers/user');
const articleController = require('./../controllers/article');
const homeController = require('./../controllers/home');

module.exports = (app) => {
  //  app.get('/user/register', userController.registerGet);

    //homeControler
    app.get('/',homeController.index);

    app.get('/user/register',userController.registerGet);
    app.post('/user/register',userController.registerPost);

    // register
    app.get('/user/register', userController.registerGet);
    app.post('/user/register', userController.registerPost);

    // Login
    app.get('/user/login', userController.loginGet);
    app.post('/user/login', userController.loginPost);

    app.get('/user/logout', userController.logout);

    //Article
    app.get('/article/create', articleController.createGet);
    app.post('/article/create',articleController.createPost);

    app.get('/article/details/:id',articleController.details);
};

