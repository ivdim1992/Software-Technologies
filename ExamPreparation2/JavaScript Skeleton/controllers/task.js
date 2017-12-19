const Task = require('../models/Task');

module.exports = {
	index: (req, res) => {
		Task.find().then(tasks => {
			let openTasks = [];
			let inProgressTasks = [];
			let finishedTasks = [];

			for (let i = 0; i < tasks.length; i++){
				let currentTasks = tasks[i];

				if(currentTasks.status === 'Open'){
					openTasks.push(currentTasks);
				}else if (currentTasks.status === 'In Progress'){
					inProgressTasks.push(currentTasks);
				}else if (currentTasks.status === 'Finished'){
					finishedTasks.push(currentTasks);
				}
			}
			res.render('task/index',{'openTasks':openTasks,
				'inProgressTasks':inProgressTasks,
				'finishedTasks':finishedTasks});
		});

	},
	createGet: (req, res) => {
		res.render('task/create');
	},
	createPost: (req, res) => {
		let task = req.body;
		Task.create(task).then(task => {
			res.redirect('/')
		})
	},
	editGet: (req, res) => {
		let id = req.params.id;

		Task.findById(id).then(task => {
			res.render('task/edit',task)
		})
	},
	editPost: (req, res) => {
        let id = req.params.id;
        let task = req.body;

        Task.findByIdAndUpdate(id,task).then(task => {
        	res.redirect('/')
		})
	}
};