const mongoose = require('mongoose');
const Article = mongoose.model('Article');

module.exports = {
    index: (req, res) => {
        Article.find({}).populate('author').then(articles => {
            res.render('home/index', {articles: articles});
        })
    }
};

