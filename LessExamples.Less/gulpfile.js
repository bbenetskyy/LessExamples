var gulp = require("gulp"),
    fs = require("fs"),
    less = require("gulp-less");


gulp.task("Build Less Files", function () {
    return gulp.src('*.less')
        .pipe(less())
        .pipe(gulp.dest('../LessExamples/LessExamples/Styles'));
});


gulp.task('default', ['Build Less Files']);