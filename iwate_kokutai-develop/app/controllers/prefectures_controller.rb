class PrefecturesController < ApplicationController
  def show
    render :json => Prefecture.all
  end
end
