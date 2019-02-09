const controllers = require('../controllers');
const restrictedPages = require('./auth');

module.exports = app => {
    app.get('/', controllers.home.index);
    
    app.get('/register', controllers.user.registerGet);
    app.post('/register', controllers.user.registerPost);
    
    app.get('/login', controllers.user.loginGet);
    app.post('/login', controllers.user.loginPost);
    
    app.post('/logout', controllers.user.logout);
    
    app.all('*', (req, res) => {
        res.status(404);
        res.send('404 Not Found');
        res.end();
    });
};