const webpack = require("webpack");
const config = require("../config/webpack.config")("development");
webpack(config, (err, stats) => {
  console.log(stats.toJson("verbose"));
});
