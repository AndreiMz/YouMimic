# frozen_string_literal: true

# default by rails
class ApplicationRecord < ActiveRecord::Base
  self.abstract_class = true
end
